using PersonService.Model;
using PersonService.Model.Base;
using System.Collections.Generic;

namespace PersonService.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
         T Create(T item);
         T FindByID(long id);
         List<T> FindAll();
         T Update(T item);
         void Delete(long id);
         bool Exists(long id);
    }
}