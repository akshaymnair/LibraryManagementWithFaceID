using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class allstudents : Form
    {
        public allstudents()
        {
            InitializeComponent();
        }

        private void allstudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uckLibMgrDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.uckLibMgrDataSet.Students);
            // TODO: This line of code loads data into the 'libraryDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.libraryDataSet.student);

        }
    }
}
