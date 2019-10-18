using System.Collections.Generic;
using RestWithAspNetTutorial.Model;
using RestWithAspNetTutorial.Repository.Generic;

namespace RestWithAspNetTutorial.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private IRepository<Person> _repository;

        public PersonBusiness(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {           
            return _repository.Create(person);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
       
    }
}
