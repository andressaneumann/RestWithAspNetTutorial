using RestWithAspNetTutorial.Model;
using System.Collections.Generic;

namespace RestWithAspNetTutorial.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindById(int id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(int id);
    }
}
