using System;
using System.Data;
using System.Data.SqlClient; // Required for database connection
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SwiftSend

{
    public partial class studentscs : Form
    {
        public studentscs()
        {
            InitializeComponent();

            // Initialize the placeholder text and color on load
            txtClass.Text = "Enter Class";
            txtClass.ForeColor = Color.Silver;

            // Attach the Enter and Leave event handlers
            txtClass.Enter += txtClass_Enter;

            // Attach the Form Click event
            this.Click += Form_Click;
        }

        private bool isPlaceholderActive = true;



        private void txtClass_TextChanged(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                txtClass.Text = "";
                txtClass.ForeColor = Color.Black;
                isPlaceholderActive = false;
            }
        }

        private void txtClass_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClass.Text))
            {
                txtClass.Text = "Enter class";
                txtClass.ForeColor = Color.Silver;
                isPlaceholderActive = true;
            }
        }

        private void txtClass_Enter(object sender, EventArgs e)
        {
            if (isPlaceholderActive)
            {
                txtClass.Text = "";
                txtClass.ForeColor = Color.Black;
                isPlaceholderActive = false;
            }
        }

        private void Form_Click(object sender, EventArgs e)
        {
            lblStudents.Focus();
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the class entered in the txtClass textbox
            string className = txtClass.Text;

            // Check if the input is not empty
            if (string.IsNullOrWhiteSpace(className) || className == "Enter Class")
            {
                MessageBox.Show("Please enter a valid class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connection string to your database
            string connectionString = @"server=.;database=dbSwiftSend;Integrated Security=SSPI";

            // Updated SQL query with corrected parameter name
            string query = @"
            SELECT s.stid, s.forename, s.surname, s.email
            FROM tblStudents s
            JOIN tblClass c ON s.cid = c.cid
            WHERE c.nameClass = @nameClass";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Correct parameter name
                        cmd.Parameters.AddWithValue("@nameClass", className);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                dgvStudents.DataSource = dt;
                            }


                            else
                            {
                                MessageBox.Show("No students found for the entered class.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
