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
    public partial class logregister : Form
    {
        public logregister()
        {
            InitializeComponent();
        }

        private void logregister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uckLibMgrDataSet1.LogRegisters' table. You can move, or remove it, as needed.
            this.logRegistersTableAdapter.Fill(this.uckLibMgrDataSet1.LogRegisters);

        }
    }
}
