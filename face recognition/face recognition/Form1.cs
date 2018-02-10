using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace face_recognition
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADD ad = new ADD();
            ad.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EDIT ed = new EDIT();
            ed.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRINT pr = new PRINT();
            pr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
