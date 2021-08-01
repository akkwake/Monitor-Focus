using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorFocus
{
    public partial class HotkeySetupControl : UserControl
    {
        bool modsAccepted;

        Keys tempModifiers = Keys.Shift;
        public KeyModifier modifiers { get; private set; }
        public Keys key { get; private set; }

        public HotkeySetupControl()
        {
            InitializeComponent();

            //Load Default
            modifiers = KeyModifier.Control | KeyModifier.Shift;
            key = Keys.Z;

            UpdateUI();
        }

        public void SetupHotkey(KeyModifier modifiers, Keys key)
        {
            this.modifiers = modifiers;
            this.key = key;
        }


        //Store modifiers pressed on KeyDown on a temp variable. Enable flag if at least 1 modifier is pressed.
        private void textBoxModifiers_KeyDown(object sender, KeyEventArgs e)
        {
            tempModifiers = e.Modifiers;
            
            if (tempModifiers == 0)
                modsAccepted = false;
            else
            {
                modsAccepted = true;
                textBoxModifiers.Text = tempModifiers.ToString();
            }
        }


        //Update hotkey modifiers if valid.
        private void textBoxModifiers_KeyUp(object sender, KeyEventArgs e)
        {
            if (modsAccepted)
            {
                modifiers = Settings.GetModifiersFromKeys(tempModifiers);
            }
        }

        //Update hotkey.
        private void textBoxKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsLetter(c))
            {
                string s = c.ToString().ToUpper();
                KeysConverter converter = new KeysConverter();
                key = (Keys)converter.ConvertFromString(s);
             
                textBoxKey.Text = s;
            }
        }


        public void UpdateUI()
        {
            textBoxModifiers.Text = modifiers.ToString();
            textBoxKey.Text = key.ToString();
        }

    }
}
