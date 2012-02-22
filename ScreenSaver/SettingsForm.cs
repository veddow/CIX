using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            //ensures the SettingsForm initially displays whatever is stored in the Registry
            LoadSettings();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        //stores the screensaver settings in the Windows Registry
        private void SaveSettings()
	    {
	        // Create or get existing Registry subkey
            // The key will be different for each user, so each user can customize
            // this screensaver with different text
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Demo_ScreenSaver");
            //key.SetValue("text", textBox.Text);
            key.SetValue("url", urlTextBox.Text);
            Microsoft.Win32.RegistryKey intervalKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Demo2_ScreenSaver");
            intervalKey.SetValue("interval", (int)intervalComboBox.SelectedIndex);
	    }
	 
	    private void LoadSettings()
	    {
	        // Get the text value stored in the Registry
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Demo_ScreenSaver");
            if (key.GetValue("text") == null)
            {
                textBox.Text = "Our Screensaver";
            }
            else
            {
               textBox.Text = (string)key.GetValue("text");
            }
            if ((string)key.GetValue("url") == "")
            {
                urlTextBox.Text = "Please enter a url";
            }
            else
            {
                urlTextBox.Text = (string)key.GetValue("url");
            }

            Microsoft.Win32.RegistryKey intervalKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Demo2_ScreenSaver");
            int interval = (int)intervalKey.GetValue("interval");
            if (interval == -1)
            {
                intervalComboBox.SelectedIndex = 0;
            }
            else
            {
                intervalComboBox.SelectedIndex = interval;
            }
	    }

        //saves the settings and closes the form when the OK button is clicked
        private void okButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
	        Close();
        }
        
        //closes the form when the cancel button is clicked
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}