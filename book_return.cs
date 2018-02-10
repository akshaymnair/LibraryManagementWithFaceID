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
    public partial class book_return : Form
    {
        public book_return()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //incremnt copies in 'book'
            //decrement avail in 'student'


            SqlConnection myConnection = new SqlConnection("User ID=sa;Initial Catalog=UckLibMgr;Password=Sqlserver2008;Data Source=127.0.0.1");

            try
            {

                myConnection.Open();
                SqlCommand mycomand = new SqlCommand("Update Issues set Status = @stat,ModifiedDate= @date "
                    + "where BookId = @bid and StudentId = @sid", myConnection);

                mycomand.Parameters.Add("@date", SqlDbType.DateTime);
                mycomand.Parameters["@date"].Value = DateTime.Now;

                mycomand.Parameters.Add("@bid", SqlDbType.Int);
                mycomand.Parameters["@bid"].Value = textBox2.Text;

                mycomand.Parameters.Add("@sid", SqlDbType.Int);
                mycomand.Parameters["@sid"].Value = textBox1.Text;

                mycomand.Parameters.Add("@stat", SqlDbType.VarChar);
                mycomand.Parameters["@stat"].Value = "Returned ";


                String txt = mycomand.CommandText;

                mycomand.ExecuteNonQuery();
                //                    
            }

            catch (Exception ie)
            {
                MessageBox.Show(ie.Message);
            }
            finally
            {
                myConnection.Close();

            }


            MessageBox.Show("NO FINE !!");
            MessageBox.Show("YOUR BOOK HAS BEEN RETURNED !!");
        }
    }
}
