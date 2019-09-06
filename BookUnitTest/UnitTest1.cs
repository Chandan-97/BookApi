using System;
using WebApplication1.Database;
using WebApplication1.Model;
using WebApplication1.Services;
using Xunit;

namespace BookUnitTest
{
    public class BookServiceFixture
    {
        BookService bookService = new BookService();
        [Fact]
        public void Get_should_return_book_test()
        {
            Book expected = new Book { MyProperty = 1 };

            Assert.Equal(expected.MyProperty, bookService.Get(1).MyProperty);
        }

        [Fact]
        public void Post_should_return_1()
        {
            var expected = 1;
            Assert.Equal(expected, bookService.Add(new Book { MyProperty = 8 }));
        }

        [Fact]
        public void Post_should_return_0()
        {
            var expected = 0;
            Assert.Equal(expected, bookService.Add(new Book { MyProperty = -1 }));
        }

        [Fact]
        public void Put_should_return_1()
        {
            var expected = 1;
            Assert.Equal(expected, bookService.Update(1, new Book { MyProperty = 8}));
        }

        [Fact]
        public void Put_should_return_0()
        {
            var expected = 0;
            Assert.Equal(expected, bookService.Update(100, new Book { MyProperty = 8 }));
        }
    }
}
