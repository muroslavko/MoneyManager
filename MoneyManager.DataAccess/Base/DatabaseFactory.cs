using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyManager.Db.DataAccess;

namespace MoneyManager.DataAccess.Base
{
    public class DatabaseFactory : IDatabaseFactory, IDisposable
    {
        private DbContext dataContext;

        public DbContext Get()
        {
            return dataContext ?? (dataContext = new MMDbContext());
        }
        public void Dispose()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }

    public interface IDatabaseFactory
    {
        DbContext Get();
    }
}
