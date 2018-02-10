using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibManager.Model;
using LibManager.Service;

namespace MultiFaceRec
{
    public partial class issue : Form
    {
        public issue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IssueService service = new IssueService();
            Issue issue = new Issue();
            issue.StudentId = Convert.ToInt32(textBox1.Text);
            issue.BookId = Convert.ToInt32(textBox2.Text);
            issue.IssueDate = DateTime.Now;
            issue.DueDate = DateTime.Now.AddDays(7);
            issue.Status = "Issued";
            issue.ModifiedDate = DateTime.Now;

            int rows = service.NewIssue(issue);
            
                MessageBox.Show(rows +"book issued");
        }
    }
}
