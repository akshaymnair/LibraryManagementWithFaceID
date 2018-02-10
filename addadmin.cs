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
    public partial class addadmin : Form
    {
        public addadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            LoginService service = new LoginService();

            String userName = textBox1.Text;
            String password = textBox2.Text;

            login.UserName = userName;
            login.Password = password;

            int rows = service.NewLogin(login);
            if (rows > 0)
            {
                MessageBox.Show("Login created");
            }
            else
            {
                MessageBox.Show("Login creation failed");
            }
        }

        private void addadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
