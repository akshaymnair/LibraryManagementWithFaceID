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
    public partial class renew : Form
    {
        public renew(string id)
        {
            InitializeComponent();
            label3.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //increment due date by 14 in table 'issue'

              SqlConnection myConnection = new SqlConnection("User ID=sa;Initial Catalog=UckLibMgr;Password=Sqlserver2008;Data Source=127.0.0.1");

            try{
               
                myConnection.Open();
                    SqlCommand mycomand = new SqlCommand("Update Issues set DueDate = @date "
                        +"where BookId = @bid", myConnection);

                    mycomand.Parameters.Add("@date", SqlDbType.DateTime);
                    mycomand.Parameters["@date"].Value = DateTime.Now.AddDays(14);

                    mycomand.Parameters.Add("@bid", SqlDbType.Int);
                    mycomand.Parameters["@bid"].Value = textBox2.Text;


                   
                    String txt = mycomand.CommandText;

                        // mycomand.Parameters.Add("@LogoutTime", SqlDbType.DateTime);
                        //mycomand.Parameters["@LogoutTime"].Value = dt;

                        //                        mycomand.Parameters.Add("@sid", SqlDbType.NChar);
                        //                      mycomand.Parameters["@sid"].Value = nam;

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

            MessageBox.Show("YOUR DUE DATE HAS RENEWED !! NEW DATE IS :"+DateTime.Now.AddDays(14));

        }
    }
}
