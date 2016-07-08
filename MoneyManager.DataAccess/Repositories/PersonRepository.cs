using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyManager.DataAccess.Base;
using MoneyManager.Db.Entity;

namespace MoneyManager.DataAccess.Repositories
{
    class PersonRepository : Repository<Person>
    {
        public PersonRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
