using MoneyManager.Db.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.DataAccess.Base
{
    class UnitOfWork
    {
        private MMDbContext _dataContext;
        private readonly IDatabaseFactory dbFactory;

        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        protected DbContext DbContext
        {
            get
            {
                return _dataContext ?? dbFactory.Get();
            }
        }
        //public IRepository<T> Repository<T>() where T : class, IEntity
        //{
        //    return new Repository<T>(_dataContext);
        //}

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}
