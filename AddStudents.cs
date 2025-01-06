using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftSend
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void AddStudents_Load(object sender, EventArgs e)
        {

        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            // Step 1: Connection string to connect to the database
            string connectionString = @"server=.;database=dbSwiftSend;Integrated Security=SSPI"; // Replace with your actual connection string

            // Step 2: Validate input
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtForename.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtClass.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            // Step 3: Retrieve the CID for the entered class name
            int classId = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT cid FROM tblClass WHERE nameClass = @className";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@className", txtClass.Text.Trim());
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        classId = Convert.ToInt32(result);
                    }
                }
            }

            if (classId == -1)
            {
                MessageBox.Show("Class not found. Please enter a valid class.");
                return;
            }

            // Step 4: Insert the new student into tblStudents
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = @"INSERT INTO tblStudents (cid, title, forename, surname, email)
                                   VALUES (@cid, @title, @forename, @surname, @email)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@cid", classId);
                    command.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                    command.Parameters.AddWithValue("@forename", txtForename.Text.Trim());
                    command.Parameters.AddWithValue("@surname", txtSurname.Text.Trim());
                    command.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student added successfully!");
                        // Optionally clear the input fields
                        txtTitle.Clear();
                        txtForename.Clear();
                        txtSurname.Clear();
                        txtEmail.Clear();
                        txtClass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error adding student. Please try again.");
                    }
                }
            }
        }


    private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
