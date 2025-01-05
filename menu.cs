using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftSend
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            // Create an instance of the classes form
            classes emailForm = new classes();

            // Hide the current form
            this.Hide();

            // Show the new form
            emailForm.Show();

        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            studentscs studentscs = new studentscs();
            studentscs.Show();
            this.Hide();
        }

        private void btnEmailCommunication_Click(object sender, EventArgs e)
        {
            // Create an instance of the emailCommunication form
            emailCommunication emailForm = new emailCommunication();

            // Hide the current form
            this.Hide();

            // Show the new form
            emailForm.Show();

        }



        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            emailTemplate studentscs = new emailTemplate();
            studentscs.Show();
            this.Hide();
        }

        private void btnMenuAddStudents_Click(object sender, EventArgs e)
        {
            // Create an instance of the classes form
            AddStudents emailForm = new AddStudents();

            // Hide the current form
            this.Hide();

            // Show the new form
            emailForm.Show();
        }
    }
}
