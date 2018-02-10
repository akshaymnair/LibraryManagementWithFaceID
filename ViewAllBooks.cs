using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibManager.Model;
using LibManager.Service;

namespace MultiFaceRec
{
    public partial class ViewAllBooks : Form
    {
        public ViewAllBooks()
        {
            InitializeComponent();
        }

        private void ViewAllBooks_Load(object sender, EventArgs e)
        {
            BookService service = new BookService();
            List<Book> books =  service.GetAllBooks();
            dataGridView1.DataSource = books;
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].Visible = false;
        }

        
    }
}
