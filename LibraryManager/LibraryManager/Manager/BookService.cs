using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Manager
{
    public class BookService
    {
        public int NewBook(Book book)
        {
            int rows = 0;
            using (var ctx = new UckLibMgrDbEntities())
            {
                ctx.Books.Add(book);
                rows = ctx.SaveChanges();
            }
            return rows;
        }

        public int UpdateBook(int bookId, String title, String author,
            String publisher, DateTime publishDate,
            String isbn)
        {
            int rows = 0;
            using (var ctx = new UckLibMgrDbEntities())
            {
                var book = ctx.Books.Find(bookId);
                book.Ttile = title;
                book.Author = author;
                book.Publisher = publisher;
                book.PublishedDate = publishDate;
                book.ISBN = isbn;
                book.ModifiedDate = DateTime.Now;
                rows = ctx.SaveChanges();
            }
            return rows;
        }

        public Book FindById(int bookId)
        {
            Book book = null;
            using (var ctx = new UckLibMgrDbEntities())
            {
                book = ctx.Books.Find(bookId);
            }
            return book;
        }

        public Book FindByTitle(String title)
        {
            Book book = null;
            using (var ctx = new UckLibMgrDbEntities())
            {
                var bk = ctx.Books.Where(b => b.Ttile == title);
                book = (Book)bk.ToList().FirstOrDefault();
            }
            return book;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = null;
            using (var ctx = new UckLibMgrDbEntities())
            {
                var bks = from book in ctx.Books
                          select book;
                books = bks.ToList();
            }
            return books;
        }

        public List<String> GetAllTitles()
        {
            List<String> titles = null;
            using (var ctx = new UckLibMgrEntities())
            {
                var title = from b in ctx.Books
                            select b.Ttile;
                titles = title.ToList();
            }
            return titles;
        }

        public List<String> GetAllAvailiableTitles()
        {
            List<String> titles = null;
            using (var ctx = new UckLibMgrEntities())
            {
                var title = from b in ctx.Books
                            select b.Ttile;
                titles = title.ToList();
            }
            return titles;
        }
    }
}
