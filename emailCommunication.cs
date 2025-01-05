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
    public partial class emailCommunication : Form
    {
        public emailCommunication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void emailCommunication_Load(object sender, EventArgs e)
        {

        }

        private void btnAttachmetUpload_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog settings
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "All files (*.*)|*.*",
                Title = "Select an Attachment"
            };

            // Show the dialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string attachmentPath = openFileDialog.FileName;

                // Extract only the file name from the full path
                string fileName = Path.GetFileName(attachmentPath);

                // Display the file name in the txtAttachmentsBox TextBox
                txtAttachmentsBox.Text = fileName;
            }
        }


        private void cblStudentSelectAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }

        private void btnMessageTemplateImport_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog settings
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Select a Message Template"
            };

            // Show the dialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string filePath = openFileDialog.FileName;

                // Read the contents of the file
                string fileContent = File.ReadAllText(filePath);

                // Display the contents in the txtMessage TextBox
                txtMessage.Text = fileContent;
            }
        }

        private void txtAttachmentsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClasses_Click(object sender, EventArgs e)
        {

        }

        private void clbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
