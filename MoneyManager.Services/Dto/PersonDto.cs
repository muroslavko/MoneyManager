using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Services.Dto
{
    public class PersonDto : IDto
    {
        public string Name { get; set; }

        public double Balance { get; set; }
    }
}
