using System.Collections.Generic;
using MoneyManager.Services.Dto;

namespace MoneyManager.Services.Services
{
    public interface IPersonService
    {
        IEnumerable<PersonDto> GetAll();
    }
}