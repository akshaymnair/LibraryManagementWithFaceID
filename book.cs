using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibManager.Model;
using LibManager.Service;

namespace MultiFaceRec

{
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String bookName = textBox1.Text;
            String author = textBox2.Text;
            String isbn = textBox3.Text;
            String publisher = textBox4.Text;
            DateTime publishDate =  dateTimePicker1.Value;

            int copies = Convert.ToInt32(textBox5.Text);
            
            BookService bookService = new BookService();
            Book book = new Book();
            book.Author = author;
            book.Ttile = bookName;
            book.ISBN = isbn;
            book.Publisher = publisher;
            book.PublishedDate = publishDate;
            book.ModifiedDate = DateTime.Now;
            
            int rows = bookService.NewBook(book);

            if (rows > 0)
            {
                MessageBox.Show("Book added.");
            }
            else
            {
                MessageBox.Show("Book not added.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
            textBox4.Text="";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewAllBooks allBooks = new ViewAllBooks();
            allBooks.Visible = true;

        }
    }
}
