using System;
using System.Collections.Generic;
using System.Linq;
using PersonService.Data.Converter.Implementations;
using PersonService.Data.VO;
using PersonService.Model;
using PersonService.Model.Context;
using PersonService.Repository;

namespace PersonService.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> respository)
        {
            _repository = respository;
            _converter = new PersonConverter();
        }
        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public PersonVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}