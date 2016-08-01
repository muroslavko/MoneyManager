using MoneyManager.Services.Dto;
using MoneyManager.Db.Entity;
using System;

namespace MoneyManager.Services.Mappers
{
    public class PersonMapper : IMapper<PersonDto, Person>
    {
        public PersonDto ToDto(Person entity)
        {
            return new PersonDto()
            {
                Name = entity.Name,
                Balance = entity.Balance
            };
        }

        public Person ToEntity(PersonDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
