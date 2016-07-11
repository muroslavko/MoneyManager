//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MoneyManager.DataAccess.Base;
//using Ninject;

//namespace MoneyManager.DataAccess
//{
//    static class DataAccessProject
//    {
//        private static void RegisterServices(IKernel kernel)
//        {
//            kernel.Bind<IDatabaseFactory>().To<DatabaseFactory>().InRequestScope();
//            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
//        }
//    }
//}
