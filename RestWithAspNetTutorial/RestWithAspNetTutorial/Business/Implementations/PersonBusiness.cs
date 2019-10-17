﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using RestWithAspNetTutorial.Model;
using RestWithAspNetTutorial.Model.Context;
using RestWithAspNetTutorial.Repository;

namespace RestWithAspNetTutorial.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private IPersonRepository _repository;

        public PersonBusiness(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {           
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
       
    }
}
