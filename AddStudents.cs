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
    }
}
