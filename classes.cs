using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Add this namespace for SQL operations

namespace SwiftSend
{
    public partial class classes : Form
    {
        public classes()
        {
            InitializeComponent();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {

        }

        


        private void btnBack2_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }



        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=.;database=dbSwiftSend;Integrated Security=SSPI";
            int newCid;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Calculate the next available cid
                    string getMaxCidQuery = "SELECT ISNULL(MAX(cid), 0) + 1 FROM tblClass";
                    using (SqlCommand getMaxCidCmd = new SqlCommand(getMaxCidQuery, conn))
                    {
                        object result = getMaxCidCmd.ExecuteScalar();
                        newCid = result != null ? Convert.ToInt32(result) : 1;
                    }

                    // Enable IDENTITY_INSERT for the table
                    //string enableIdentityInsertQuery = "SET IDENTITY_INSERT tblClass ON";
                    //using (SqlCommand enableIdentityCmd = new SqlCommand(enableIdentityInsertQuery, conn))
                    //{
                    //    enableIdentityCmd.ExecuteNonQuery();
                    //}

                    // Insert the new row with the calculated cid
                    string insertQuery = "INSERT INTO tblClass (nameClass, yearGroup, number) VALUES (@nameClass, @yearGroup, @number)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@nameClass", txtClassName.Text);
                        insertCmd.Parameters.AddWithValue("@yearGroup", txtYearGroup.Text);
                        insertCmd.Parameters.AddWithValue("@number", txtNumberInClass.Text);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Class saved successfully!");

                            txtClassName.Text = "";
                            txtYearGroup.Text = "";
                            txtNumberInClass.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted.");
                        }
                    }

                    // Disable IDENTITY_INSERT for the table
                    //string disableIdentityInsertQuery = "SET IDENTITY_INSERT tblClass OFF";
                    //using (SqlCommand disableIdentityCmd = new SqlCommand(disableIdentityInsertQuery, conn))
                    //{
                    //    disableIdentityCmd.ExecuteNonQuery();
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }





        private void txtClassId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

