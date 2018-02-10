using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiFaceRec
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal f = new FrmPrincipal();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addadmin d = new addadmin();
            d.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            book b = new book();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            issue s = new issue();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            allstudents a = new allstudents();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            logregister l = new logregister();
            l.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            book_return b = new book_return();
            b.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            issued i = new issued();
            i.Show();
        }

        
    }
}
