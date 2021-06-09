using System.Collections.Generic;
using PersonService.Model;

namespace PersonService.Business
{
    public interface IBookBusiness
    {
         Book Create(Book book);
         Book FindByID(long id);
         List<Book> FindAll();
         Book Update(Book book);
         void Delete(long id);
    }
}