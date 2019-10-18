using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using RestWithAspNetTutorial.Model;
using RestWithAspNetTutorial.Model.Context;
using RestWithAspNetTutorial.Repository;
using RestWithAspNetTutorial.Repository.Generic;

namespace RestWithAspNetTutorial.Business.Implementations
{
    public class BookBusiness : IBookBusiness
    {
        private IRepository<Book> _repository;

        public BookBusiness(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {           
            return _repository.Create(book);
        }

        public void Delete(int id)
        { 
            _repository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
       
    }
}
