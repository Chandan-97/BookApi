using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Database
{
    public class BookData
    {
        static List<Book> bookList = new List<Book>();
        public BookData()
        {
            bookList.Add(new Book { MyProperty = 1 });
            bookList.Add(new Book { MyProperty = 2 });
            bookList.Add(new Book { MyProperty = 3 });
            bookList.Add(new Book { MyProperty = 4 });
            bookList.Add(new Book { MyProperty = 5 });
        }

        public List<Book> Get()
        {
            return bookList;
        }

        public Book Get(int id)
        {
            return null;
        }

        public void Delete(int id)
        {
            bookList.Remove(this.Get(id));
        }

        public void Add(Book book)
        {
            bookList.Add(book);
        }

        public void Update(int index, Book newBook)
        {
            bookList[index] = newBook;
        }
    }
}
