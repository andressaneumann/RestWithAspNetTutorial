using RestWithAspNetTutorial.Data.VO;
using RestWithAspNetTutorial.Model;
using System.Collections.Generic;

namespace RestWithAspNetTutorial.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(int id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(int id);
    }
}
