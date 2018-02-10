using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Manager
{
    public class BookManager
    {
        public int NewBook(Book book)
        {
            int rows = 0;
            using(var ctx = new UckLibMgrDbEntities())
            {
                ctx.Books.Add(book);
                rows = ctx.SaveChanges();
            }
            return rows;
        }

        public Book FindById(int id)
        {
            Book book;
            using (var ctx = new UckLibMgrDbEntities())
            {
                book = ctx.Books.Find(id);
            }
            return book;
        }


    }
}
