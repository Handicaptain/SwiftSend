using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Net.Mail;

namespace SwiftSend
{
    public partial class emailCommunication : Form
    {
        public emailCommunication()
        {
            InitializeComponent();
        }

        private void emailCommunication_Load(object sender, EventArgs e)
        {
            PopulateClasses();
        }

        private void PopulateClasses()
        {
            // Connection string to your local SQL Server database
            string connectionString = @"server=.;database=dbSwiftSend;Integrated Security=SSPI";

            // Query to fetch the data from tblClass
            string query = "SELECT nameClass FROM tblClass";

            try
            {
                // Open a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing items in the CheckedListBox
                            cblClasses.Items.Clear();

                            // Loop through the results and add each to the CheckedListBox
                            while (reader.Read())
                            {
                                cblClasses.Items.Add(reader["nameClass"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., display an error message)
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }

        private void btnAttachmetUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "All files (*.*)|*.*",
                Title = "Select an Attachment"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string attachmentPath = openFileDialog.FileName;
                string fileName = Path.GetFileName(attachmentPath);
                txtAttachmentsBox.Text = fileName;
            }
        }

        private void btnMessageTemplateImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Select a Message Template"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);
                txtMessage.Text = fileContent;
            }
        }

        private void cblClassesSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the "Select All" checkbox is checked
            if (cblClassesSelectAll.Checked)
            {
                // Loop through all items in the CheckedListBox and set them as checked
                for (int i = 0; i < cblClasses.Items.Count; i++)
                {
                    cblClasses.SetItemChecked(i, true);
                }
            }
            else
            {
                // Loop through all items in the CheckedListBox and uncheck them
                for (int i = 0; i < cblClasses.Items.Count; i++)
                {
                    cblClasses.SetItemChecked(i, false);
                }
            }
        }

        private void clbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchClasses_Click(object sender, EventArgs e)
        {
            // Connection string to your local SQL Server database
            string connectionString = @"server=.;database=dbSwiftSend;Integrated Security=SSPI";

            // Get the selected classes from the CheckedListBox
            var selectedClasses = cblClasses.CheckedItems;

            // If no classes are selected, show a message and return
            if (selectedClasses.Count == 0)
            {
                MessageBox.Show("Please select at least one class.");
                return;
            }

            // Build a list of selected class names
            var classNames = new List<string>();
            foreach (var item in selectedClasses)
            {
                classNames.Add(item.ToString());
            }

            // Prepare the SQL query to fetch students for the selected classes
            // Use a parameterized query to avoid SQL injection
            string query = @"
            SELECT s.forename, s.surname
            FROM tblStudents s
            INNER JOIN tblClass c ON s.cid = c.cid
            WHERE c.nameClass IN (@ClassNames)";

            try
            {
                // Open a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Replace placeholders in the query with actual class names
                    query = query.Replace("@ClassNames", string.Join(", ", classNames.Select(c => $"'{c}'")));

                    // Execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing items in the CheckedListBox
                            clbStudents.Items.Clear();

                            // Loop through the results and add each student's full name to the CheckedListBox
                            while (reader.Read())
                            {
                                string fullName = $"{reader["forename"]} {reader["surname"]}";
                                clbStudents.Items.Add(fullName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., display an error message)
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void cblStudentSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the "Select All" checkbox is checked
            if (cblStudentSelectAll.Checked)
            {
                // Loop through all items in the CheckedListBox and set them as checked
                for (int i = 0; i < clbStudents.Items.Count; i++)
                {
                    clbStudents.SetItemChecked(i, true);
                }
            }
            else
            {
                // Loop through all items in the CheckedListBox and uncheck them
                for (int i = 0; i < clbStudents.Items.Count; i++)
                {
                    clbStudents.SetItemChecked(i, false);
                }
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAttachmentsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Ensure title and message are provided
            string subject = txtTitle.Text.Trim();
            string body = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Please enter an email subject.");
                return;
            }

            if (string.IsNullOrEmpty(body))
            {
                MessageBox.Show("Please enter an email message.");
                return;
            }

            // Get the selected students
            var selectedStudents = clbStudents.CheckedItems;
            if (selectedStudents.Count == 0)
            {
                MessageBox.Show("Please select at least one student.");
                return;
            }

            // Connection string to your local SQL Server database
            string connectionString = @"server=.;database=dbSwiftSend;Integrated Security=SSPI";

            // Collect the email addresses for the selected students
            List<string> emailAddresses = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (var studentName in selectedStudents)
                    {
                        // Split the full name into forename and surname
                        string[] nameParts = studentName.ToString().Split(' ');
                        string forename = nameParts[0];
                        string surname = nameParts.Length > 1 ? nameParts[1] : "";

                        // Query to fetch the email address of the selected student
                        string query = @"
                SELECT email
                FROM tblStudents
                WHERE forename = @Forename AND surname = @Surname";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Forename", forename);
                            command.Parameters.AddWithValue("@Surname", surname);

                            object email = command.ExecuteScalar();
                            if (email != null)
                            {
                                emailAddresses.Add(email.ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching email addresses: {ex.Message}");
                return;
            }

            if (emailAddresses.Count == 0)
            {
                MessageBox.Show("No valid email addresses found for the selected students.");
                return;
            }

            // Send emails using Outlook's SMTP server
            try
            {
                using (System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.office365.com"))
                {
                    smtpClient.Port = 587; // Outlook's SMTP port
                    smtpClient.Credentials = new System.Net.NetworkCredential("eb05263952@priestley.ac.uk", "Gc5xjvjr9Kyt!");
                    smtpClient.EnableSsl = true; // Enable TLS/SSL

                    foreach (string emailAddress in emailAddresses)
                    {
                        using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                        {
                            mail.From = new System.Net.Mail.MailAddress("eb05263952@priestley.ac.uk");
                            mail.To.Add(emailAddress);
                            mail.Subject = subject;
                            mail.Body = body;

                            smtpClient.Send(mail);
                        }
                    }
                }

                MessageBox.Show("Emails sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending emails: {ex.Message}");
            }
        }


    }
}
