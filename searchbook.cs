using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibManager.Model;
using LibManager.Service;

namespace MultiFaceRec
{
    public partial class searchbook : Form
    {
        public searchbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            SqlConnection myConnection = new SqlConnection("User ID=sa;Initial Catalog=UckLibMgr;Password=Sqlserver2008;Data Source=127.0.0.1");

            try
            {
                myConnection.Open();
                SqlCommand mycmnd = new SqlCommand("select copies from books where Ttile='" + textBox1.Text+"'", myConnection);
                SqlDataReader reader = mycmnd.ExecuteReader();
                if (reader == null)
                {
                    MessageBox.Show("No title found");
                    return;
                }
                if (reader != null && reader.Read())
                {
                    int copy = reader.GetInt32(0);
                    MessageBox.Show("Available Copies : "+copy.ToString());
                }
                else
                {
                    MessageBox.Show("No title found");
                }
                
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

        
    }
}
