using System.Collections.Generic;
using PersonService.Data.VO;

namespace PersonService.Business
{
    public interface IBookBusiness
    {
         BookVO Create(BookVO book);
         BookVO FindByID(long id);
         List<BookVO> FindAll();
         BookVO Update(BookVO book);
         void Delete(long id);
    }
}