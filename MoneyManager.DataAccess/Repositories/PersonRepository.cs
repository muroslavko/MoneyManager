using MoneyManager.DataAccess.Base;
using MoneyManager.DataAccess.Interfaces;
using MoneyManager.Db.Entity;

namespace MoneyManager.DataAccess.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
