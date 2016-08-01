using MoneyManager.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using MoneyManager.Db.Entity;
using MoneyManager.Services.Dto;
using MoneyManager.Services.Mappers;
using MoneyManager.Shared.Logger;

namespace MoneyManager.Services.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper<PersonDto, Person> _mapper;
        private readonly ILogger _logger;

        public PersonService(IPersonRepository personRepository, IMapper<PersonDto, Person> mapper, ILoggerFactory loggerFactory)
        {
            _personRepository = personRepository;
            _mapper = mapper;
            _logger = loggerFactory.CreateLogger<PersonService>();
        }

        public IEnumerable<PersonDto> GetAll()
        {
            try
            {
                return _personRepository.Query().Select(_mapper.ToDto).ToList();
            }
            catch (Exception ex)
            {
                _logger.Debug(ex);
                return null;
            }
        }
    }
}
