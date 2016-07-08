using MoneyManager.Db.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Db.DataAccess
{
    public class MMDbContext : DbContext
    {
        static MMDbContext()
        {
            Database.SetInitializer(new MMDbInitializer());
        }

        public MMDbContext() : base("name=MoneyManagerDb")
        {

        }

        public virtual DbSet<Person> Person { get; set; }

    }
}
