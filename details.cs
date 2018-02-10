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
    public partial class details : Form
    {
        string id;
        public details(string idd)
        {
            id = idd;
            InitializeComponent();
            label5.Text = idd;

            SqlConnection myConnection = new SqlConnection("User ID=sa;Initial Catalog=UckLibMgr;Password=Sqlserver2008;Data Source=127.0.0.1");

            try
            {
                myConnection.Open();
                SqlCommand mycmnd = new SqlCommand("select Name,Address,Email,Branch,Year from Students where StudentId=" + label5.Text, myConnection);
                SqlDataReader reader = mycmnd.ExecuteReader();
                reader.Read();
               labelname.Text = reader[0].ToString();
               labelbranch.Text = reader[3].ToString();
               labelyr.Text= reader[4].ToString();
               label8.Text = reader[2].ToString();
               label9.Text = reader[1].ToString();
               
            }

            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
            finally
            {
                myConnection.Close();

            }

           
            try
            {
                myConnection.Open();
                SqlCommand mycmnd = new SqlCommand("select BookId from Issues where StudentId=" + label5.Text, myConnection);
                SqlDataReader reader = mycmnd.ExecuteReader();
                reader.Read();
                label10.Text = reader[0].ToString();
               // label12.Text = reader[2].ToString();
               // label11.Text = reader[1].ToString();

            }

            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
            finally
            {
                myConnection.Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            renew r = new renew(id);
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchbook s = new searchbook();
            s.Show();
        }

        

        
    }
}
