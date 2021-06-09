using System.Collections.Generic;
using System.Linq;
using PersonService.Data.Converter.Contract;
using PersonService.Data.VO;
using PersonService.Model;

namespace PersonService.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;
            return new Book
            {
                Id = origin.Id,
                author = origin.author,
                launchDate = origin.launchDate,
                price = origin.price,
                title = origin.title
            };
        }

        public List<Book> Parse(List<BookVO> origin)
        {
             if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public BookVO Parse(Book origin)
        {
           if (origin == null) return null;
            return new BookVO
            {
                Id = origin.Id,
                author = origin.author,
                launchDate = origin.launchDate,
                price = origin.price,
                title = origin.title
            };
        }

        public List<BookVO> Parse(List<Book> origin)
        {
             if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}