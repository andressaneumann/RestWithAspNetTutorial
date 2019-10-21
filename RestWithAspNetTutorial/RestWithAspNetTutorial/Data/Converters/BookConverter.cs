using RestWithAspNetTutorial.Data.Converter;
using RestWithAspNetTutorial.Data.VO;
using RestWithAspNetTutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNetTutorial.Data.Converters
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null) return new Book();

            return new Book
            {
                Id = origin.Id,
                Author = origin.Author,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public BookVO Parse(Book origin)
        {
            if(origin == null) return new BookVO();

            return new BookVO
            {
                Id = origin.Id,
                Author = origin.Author,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public List<Book> ParseList(List<BookVO> origin)
        {
            if (origin == null) return new List<Book>();

            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> ParseList(List<Book> origin)
        {
            if (origin == null) return new List<BookVO>();

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
