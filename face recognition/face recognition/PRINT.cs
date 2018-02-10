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
    public partial class PRINT : Form
    {
        public PRINT()
        {
            InitializeComponent();
        }

        private void PRINT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'face_detectionDataSet.image_table' table. You can move, or remove it, as needed.
            this.image_tableTableAdapter.Fill(this.face_detectionDataSet.image_table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
    }
}
