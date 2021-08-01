using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorFocus
{
    /// <summary>
    /// 
    /// </summary>
    public static class Settings
    {
        public static readonly string settingsFileName = "settings.dat";

        public static bool RunOnStartup { get; private set; }
        public static bool StartMinimized { get; private set; }
        public static KeyModifier HotkeyModifiers { get; private set; }
        public static Keys Hotkey { get; private set; }
        public static int QuickReleaseIndex { get; private set; }



        public static void SaveSettings(bool runOnStartup, bool runMinimized, KeyModifier modifiers, Keys key, int quickReleaseIndex)
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            //Registry settings - Add to startup
            if (runOnStartup)
                rkApp.SetValue("MonitorFocus", Assembly.GetExecutingAssembly().Location);
            else
                rkApp.DeleteValue("MonitorFocus", false);
            rkApp.Close();

            //File Settings
            string directory = Application.StartupPath + '\\' + settingsFileName;
            using (FileStream stream = new FileStream(directory, FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    string s = modifiers.ToString() + "|" +
                        key + "|" +
                        quickReleaseIndex + "|" +
                        runMinimized;

                    writer.Write(s);
                }
            }
        }

        
        public static bool LoadSettings()
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rkApp.GetValue("MonitorFocus") == null)
                RunOnStartup = false;
            else
                RunOnStartup = true;


            string directory = Application.StartupPath + '\\' + settingsFileName;
            if (!File.Exists(directory))
                return false;
            else
            {
                using (FileStream stream = new FileStream(directory, FileMode.Open))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        string s = reader.ReadString();

                        string[] settings = s.Split('|');

                        KeysConverter converter = new KeysConverter();
                        
                        Keys tempModifiers = (Keys)converter.ConvertFromString(settings[0]);
                        HotkeyModifiers = GetModifiersFromKeys(tempModifiers);

                        Hotkey = (Keys)converter.ConvertFromString(settings[1]);
                        
                        QuickReleaseIndex = Convert.ToInt32(settings[2]);

                        StartMinimized = Convert.ToBoolean(settings[3]);

                        return true;
                    }
                }
            }
        }


        /// <summary>
        /// Returns modifiers from a Keys variable.
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public static KeyModifier GetModifiersFromKeys(Keys keys)
        {
            KeyModifier modifiers = 0;

            if (keys.HasFlag(Keys.Control))
                modifiers = modifiers | KeyModifier.Control;

            if (keys.HasFlag(Keys.Shift))
                modifiers = modifiers | KeyModifier.Shift;

            if (keys.HasFlag(Keys.Alt))
                modifiers = modifiers | KeyModifier.Alt;

            return modifiers;
        }


    }
}
