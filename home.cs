using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;


namespace MultiFaceRec
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paswrd f = new paswrd();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                
                student s = new student();
                s.Show();

            }
            catch(Exception)
            {
                MessageBox.Show("Student database empty, please add students!!", "WARNING :", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.Show();
        }
    }
}
