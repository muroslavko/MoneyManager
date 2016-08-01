//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MoneyManager.DataAccess.Base;
//using Ninject;

//namespace MoneyManager.DataAccess
//{
//    public static class DataAccessProject
//    {
//        public static void RegisterServices(IKernel kernel)
//        {
//            kernel.Bind<IDatabaseFactory>().To<DatabaseFactory>().InTransientScope();
//            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InTransientScope();
//        }
//    }
//}
