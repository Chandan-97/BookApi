using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Database;
using WebApplication1.Model;

namespace WebApplication1.Services
{
    public class BookService
    {
        BookData bookData = new BookData();
        public Book Get(int id)
        {
            if (id < 0)
            {
                throw new Exception();
            }
            List<Book> listBook = bookData.Get();
            foreach (var book in listBook)
            {
                if (book.MyProperty == id) return book;
            }
            return new Book { MyProperty = -1 };
        }

        public List<Book> Get()
        {
            return bookData.Get();
        }

        public void Delete(int id)
        {
            try
            {
                bookData.Delete(id);
            }
            catch(Exception e){
                throw e;
            }
        }

        public int Add(Book book)
        {
            if(book.MyProperty < 0)
            {
                return 0;
            }
            bookData.Add(book);

            return 1;
        }

        public int Update(int id, Book book)
        {
            if(id < 0 || book.MyProperty < 0)
            {
                return 0;
            }

            List<Book> listBook = bookData.Get();

            for(var i=0; i<listBook.Count(); i++)
            {
                if(listBook[i].MyProperty == id)
                {
                    bookData.Update(i, book);
                    return 1;
                }
            }
            return 0;
        }
    }
}
