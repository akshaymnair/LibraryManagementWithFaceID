using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibManager.Model;
using LibManager.Service;

namespace MultiFaceRec
{   
    public partial class paswrd : Form
    {
        string password;
        public paswrd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = textBox1.Text;
            String password = textBox2.Text;

            LoginService loginService = new LoginService();
            Login login =  loginService.FindByUserName(userName);
            if (login != null)
            {
                if (login.Password.Equals(password))
                {
                    admin f = new admin();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Check the login details. ");
                }
            }
            else
            {
                MessageBox.Show("Check the login details. ");
            }
        }
    }
}
