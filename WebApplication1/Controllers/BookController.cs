using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookService bookService;

        public BookController()
        {
             bookService = new BookService();
        }

        // GET: api/Book
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return bookService.Get();
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public Book Get(int id)
        {
            return bookService.Get(id);
        }

        // POST: api/Book
        [HttpPost]
        public string Post([FromBody] Book book)
        {
            bookService.Add(book);
            return "Object Added";
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Book book)
        {
            bookService.Update(id, book);
            return "Book Updated";
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            bookService.Delete(id);
            return "Book Deleted";
        }
    }
}
