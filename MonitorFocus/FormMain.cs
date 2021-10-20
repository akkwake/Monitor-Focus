using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using System.Reflection;

namespace MonitorFocus
{
    [Flags]
    public enum KeyModifier
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
    }

    public partial class FormMain : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        bool cursorConfined = false;
        bool quickRelease = false;
        Keys quickReleaseKey;

        public FormMain()
        {
            InitializeComponent();
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Point startPosition = new Point(bounds.Right - Size.Width - 20, bounds.Bottom - Size.Height - 50);
            this.Location = startPosition;
        }

        public void RegisterToggleHotkey(KeyModifier modifier, Keys key)
        {
            RegisterHotKey(this.Handle, 0, (int)modifier, (int)key);
        }

        public void UnregisterToggleHotkey()
        {
            UnregisterHotKey(this.Handle, 0);
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.


                ToggleCursorClipping();
            }
        }



        void ConfineCursor()
        {
            //Get index of monitor the cursor is in
            int i = MonitorData.GetCursorMonitorIndex();

            
            if (i >= 0) //Valid index
            {
                //Setup cursor clipping
                Cursor.Clip = new Rectangle(Screen.AllScreens[i].Bounds.Location, Screen.AllScreens[i].Bounds.Size);

                //UI stuff
                trayIcon.Icon = Properties.Resources.mconf;
                string s = "Cursor Confined - {" + i.ToString() + '}';
                labelTitle.Text = s;
                trayIcon.Text = s;
            }
            else        //Invalid Index
            {
                switch (i)
                {
                    case -1:    //Single monitor
                        break;
                    case -2:    //Cursor outside of bounds
                        break;
                }
            }
        }

        void ReleaseCursor()
        {
            //Clear cursor clipping
            Cursor.Clip = Rectangle.Empty;

            //UI stuff
            trayIcon.Icon = Properties.Resources.munconf;
            string s = "Cursor Released";
            labelTitle.Text = s;
            trayIcon.Text = s;
        }


        void ToggleCursorClipping()
        {
            if (cursorConfined)
            {
                timer.Stop();
                ReleaseCursor();
                cursorConfined = false;
            }
            else
            {
                ConfineCursor();
                cursorConfined = true;

                timer.Start();
            }
        }




        private void FormMain_Load(object sender, EventArgs e)
        {
            //Load settings
            bool settingsFileFound = Settings.LoadSettings();
            if (settingsFileFound)
            {
                checkBoxStartup.Checked = Settings.RunOnStartup;
                checkBoxStartMinimized.Checked = Settings.StartMinimized;
                hotkeySetupControl.SetupHotkey(Settings.HotkeyModifiers, Settings.Hotkey);
                hotkeySetupControl.UpdateUI();
                comboBoxQuickRelease.SelectedIndex = Settings.QuickReleaseIndex;
            }
            else
                comboBoxQuickRelease.SelectedIndex = 2;


            //Setup global Hotkey
            KeyModifier modifiers = hotkeySetupControl.modifiers;
            Keys key = hotkeySetupControl.key;
            RegisterToggleHotkey(modifiers, key);


            //Confine cursor
            ToggleCursorClipping();


            //UI stuff
            this.TopMost = true;
        }


        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (checkBoxStartMinimized.Checked)
                this.Hide();
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Monitor Focus", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    UnregisterToggleHotkey();
                    Settings.SaveSettings(checkBoxStartup.Checked, checkBoxStartMinimized.Checked, hotkeySetupControl.modifiers, hotkeySetupControl.key, comboBoxQuickRelease.SelectedIndex);
                }
                else
                    e.Cancel = true;
            }
        }



        private void hotkeySetupControl_Enter(object sender, EventArgs e)
        {
            //UI stuff
            panelHotkeySetup.Visible = true;
        }

        //This event updates the toggle hotkey. There might be a better way to do this.
        private void hotkeySetupControl_Leave(object sender, EventArgs e)
        {
            UnregisterToggleHotkey();

            //Update hotkey
            KeyModifier modifiers = hotkeySetupControl.modifiers;
            Keys key = hotkeySetupControl.key;
            RegisterToggleHotkey(modifiers, key);

            //UI stuff
            panelHotkeySetup.Visible = false;
        }


        // Removes cursor clipping while quickReleaseKey is pressed.
        private void timer_Tick(object sender, EventArgs e)
        {
            //Check if quickReleaseKey is pressed
            if ((Control.ModifierKeys & quickReleaseKey) == quickReleaseKey)
            {
                if (!quickRelease)
                {
                    ReleaseCursor();
                    quickRelease = true;
                }
            }
            else
            {
                ConfineCursor();
                quickRelease = false;
            }
        }

        

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (cursorConfined)
            {
                toggleToolStripMenuItem.Text = "Release Cursor";
            }
            else
            {
                toggleToolStripMenuItem.Text = "Confine Cursor";
            }
        }

        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleCursorClipping();
        }

        private void comboBoxQuickRelease_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeysConverter converter = new KeysConverter();
            Keys k = (Keys)converter.ConvertFromString(comboBoxQuickRelease.SelectedItem.ToString());
            quickReleaseKey = k;
        }

        
        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            //This ensures that hitting escape to minimize will trigger
            //the hotkeySetupControl_Leave(..) event
            buttonMinimize.Select();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
