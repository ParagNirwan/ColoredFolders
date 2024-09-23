using System;
using System.Windows.Forms;
using Microsoft.Win32;  // Import for working with the Windows Registry

namespace ColoredFolders
{
    public partial class ColoredFolders : Form
    {
        private const string registryPath = @"Software\ColoredFolders";  // The location to save the On/Off setting
        private const string folderRegistryPath = @"Folder\shell\coloredFolders";  // Path for folder color settings in the registry

        public ColoredFolders()
        {
            InitializeComponent();
            LoadSettings();  // Load the saved On/Off state when the form loads
        }

        // Event handler when the 'On' RadioButton is selected
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                // This will be executed when the 'On' RadioButton is selected
                WriteOnOffRegistry("On");  // Save the On state
                WriteFolderColorRegistry();  // Write the folder color settings to the registry
                MessageBox.Show("Registry updated and Colored Folders is On.");
            }
        }

        // Event handler when the 'Off' RadioButton is selected
        private void Off_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                // This will be executed when the 'Off' RadioButton is selected
                WriteOnOffRegistry("Off");  // Save the Off state
                RemoveFolderColorRegistry();  // Remove folder color settings from the registry
                MessageBox.Show("Colored Folders feature disabled.");
            }
        }

        // Function to save the On/Off setting to the registry
        private void WriteOnOffRegistry(string value)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath);
                if (key != null)
                {
                    key.SetValue("FolderColorFeature", value, RegistryValueKind.String);  // Save "On" or "Off"
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the setting: " + ex.Message);
            }
        }

        // Function to write the folder color settings to the registry (when "On" is selected)
        private void WriteFolderColorRegistry()
        {
            try
            {
                RegistryKey key = Registry.ClassesRoot.CreateSubKey(folderRegistryPath);
                if (key != null)
                {
                    key.SetValue("MUIVerb", "Set Folder Color", RegistryValueKind.String);
                    key.SetValue("SubCommands", "Red; Green; Blue; Purple; Pink; Orange; Teal; Grey;", RegistryValueKind.String);
                    key.SetValue("Icon", @"C:\Users\pnirw\Documents\ColoredFolders\assets\Blue (2).ico", RegistryValueKind.String);
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to registry: " + ex.Message);
            }
        }

        // Function to remove the folder color settings from the registry (when "Off" is selected)
        private void RemoveFolderColorRegistry()
        {
            try
            {
                RegistryKey key = Registry.ClassesRoot.OpenSubKey(folderRegistryPath, true);
                if (key != null)
                {
                    key.DeleteValue("MUIVerb", false);  // Optionally remove values if needed
                    key.DeleteValue("SubCommands", false);
                    key.DeleteValue("Icon", false);
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modifying the registry: " + ex.Message);
            }
        }

        // Function to load the On/Off setting from the registry
        private void LoadSettings()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath);
                if (key != null)
                {
                    string featureState = key.GetValue("FolderColorFeature", "Off").ToString();  // Default to "Off" if not found
                    key.Close();

                    // Set the radio buttons based on the saved value
                    if (featureState == "On")
                    {
                        On.Checked = true;  // On is selected
                    }
                    else
                    {
                        Off.Checked = true;  // Off is selected
                    }
                }
                else
                {
                    // If the key does not exist, default to Off (first run)
                    Off.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the setting: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
