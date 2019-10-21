using System.Collections.Generic;
using RestWithAspNetTutorial.Data.Converters;
using RestWithAspNetTutorial.Data.VO;
using RestWithAspNetTutorial.Model;
using RestWithAspNetTutorial.Repository.Generic;

namespace RestWithAspNetTutorial.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusiness(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);

            return _converter.Parse(personEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PersonVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);

            return _converter.Parse(personEntity);
        }
       
    }
}
