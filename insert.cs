using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace MultiFaceRec
{
    public partial class insert : Form
    {
        public insert(string id,Image<Gray, byte> result)
        {
            InitializeComponent();
            textBox1.Text = id;
            imageBox1.Image = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("User ID=sa;Initial Catalog=UckLibMgr;Password=Sqlserver2008;Data Source=127.0.0.1");

            try
            {
                myConnection.Open();

                SqlCommand mycomand = new SqlCommand("insert into students (StudentId,name,address,email,branch,year)" +
                "values (@id,@name,@address,@email,@branch,@year)", myConnection);

                mycomand.Parameters.Add("@name", SqlDbType.VarChar);
                mycomand.Parameters["@name"].Value = textBox2.Text;

                mycomand.Parameters.Add("@address", SqlDbType.VarChar);
                mycomand.Parameters["@address"].Value = textBox4.Text;

                mycomand.Parameters.Add("@email", SqlDbType.VarChar);
                mycomand.Parameters["@email"].Value = textBox3.Text;

                mycomand.Parameters.Add("@branch", SqlDbType.VarChar);
                mycomand.Parameters["@branch"].Value = comboBox2.Text;

                mycomand.Parameters.Add("@year", SqlDbType.Int);
                mycomand.Parameters["@year"].Value = comboBox1.Text;

                mycomand.Parameters.Add("@id", SqlDbType.Int);
                mycomand.Parameters["@id"].Value = textBox1.Text;

                mycomand.ExecuteNonQuery();

                MessageBox.Show("Student Added !!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text="";
            comboBox2.Text="";
            textBox2.Text="";
            textBox4.Text = "";
            textBox3.Text = "";

        }
    }
}
