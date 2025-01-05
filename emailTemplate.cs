using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftSend
{
    public partial class emailTemplate : Form
    {
        public emailTemplate()
        {
            InitializeComponent();
        }

        private void lblPath_Click(object sender, EventArgs e)
        {

        }

        private void emailTemplate_Load(object sender, EventArgs e)
        {

        }

        private void txtEmailTemplateName_TextChanged(object sender, EventArgs e)
        {
            // variable for text inputted into template name box
            string emailTemplateName = txtEmailTemplateName.Text;

        }


        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            string emailTemplateName = txtEmailTemplateName.Text.Trim();

            // check to make sure name is entered
            if (string.IsNullOrWhiteSpace(emailTemplateName))
            {
                MessageBox.Show("Please enter a name for the template.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // check if a file path has been selected
                if (string.IsNullOrWhiteSpace(txtFilePath.Text))
                {
                    MessageBox.Show("Please select a folder to save the template file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // make sure file name has a .txt extension
                if (!emailTemplateName.EndsWith(".txt"))
                {
                    emailTemplateName += ".txt";
                }

                string filePath = Path.Combine(txtFilePath.Text, emailTemplateName);

                // check if the file already exists
                if (File.Exists(filePath))
                {
                    MessageBox.Show("A file with this name already exists. Please choose a different name or folder.", "File Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string messageText = txtEmailTemplateMessage.Text;

                // write the text to the file at selected path
                File.WriteAllText(filePath, messageText);

                // display a message to the user to confirm save
                MessageBox.Show("Template message saved successfully at: " + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // handle any errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder to save the template";

                // show the message and check if the user clicked ok
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // display the selected path in the txtFilePath textbox
                    txtFilePath.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }
    }
}