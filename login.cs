﻿using System;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "eburns";
            string password = "password";

            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            if (enteredUsername == username && enteredPassword == password)
            {
                menu emailForm = new menu();
                this.Hide();
                emailForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
    }
}
