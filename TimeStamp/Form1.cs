using System;
using System.Windows.Forms;
using System.IO;

namespace TimeStamp
{
    public partial class Form1 : Form
    {
        string itemPath;

        public Form1(string[] args)
        {
            InitializeComponent();
            InitializeForm(args);
        }

        // Initialize the form based on command line arguments
        private void InitializeForm(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                itemPath = args[0];
                labelitem.Text = itemPath;
                ToolTip tooltip = new ToolTip();
                tooltip.SetToolTip(labelitem, itemPath);
            }
            else
            {
                // Display an error message if no command line parameters are provided
                MessageBox.Show("Missing command line parameters\nPlease start with TimeStamp.exe \"c:\\example\\Program.exe\"");
                Environment.Exit(0);
            }
        }
        // Handle key events, including Enter and Escape keys
        private void KeyDownDO(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                CheckItem();
            }

            if (e.KeyCode == Keys.Escape)
            {
                // Confirm exit when Escape key is pressed
                if (MessageBox.Show("Exit TimeStamp ?", "Close ?", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
            }
        }
        // Handle the click event of the "Set" button
        private void buttonSet_Click(object sender, EventArgs e)
        {
            CheckItem();
        }
        // Check if the specified path is a file or a directory
        private void CheckItem()
        {
            if (Directory.Exists(itemPath) || File.Exists(itemPath))
            {
                SetTime(File.Exists(itemPath));
            }
            else
            {
                // Display an error message if neither a folder nor a file could be found
                MessageBox.Show($"Neither a folder nor a file could be found\n{itemPath}");
            }
            Environment.Exit(0);
        }

        // Set the last write time of the specified file or directory
        private void SetTime(bool isFile)
        {
            try
            {
                DateTime newTime = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second);

                if (isFile)
                {
                    File.SetLastWriteTime(itemPath, newTime);
                }
                else
                {
                    Directory.SetLastWriteTime(itemPath, newTime);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        // Handle the click event of the close button
        private void labelClose_Click(object sender, EventArgs e)
        {
            // Confirm exit when the close button is clicked
            if (MessageBox.Show("Exit TimeStamp ?", "Close ?", MessageBoxButtons.YesNo) == DialogResult.Yes) Environment.Exit(0);     
        }
        
    }
}
