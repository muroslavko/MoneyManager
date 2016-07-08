using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Db.Entity
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }

    public interface IEntity
    {
        int Id { get; set; }
    }

    public interface ISoftDeleteEntity
    {
        bool IsDeleted { get; set; }
    }


    public abstract class BaseSoftDeleteEntity : IEntity, ISoftDeleteEntity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
    }

    public static class EntityExtension
    {
        public static long NotPersisted = 0;

        public static bool IsNew(this IEntity entity)
        {
            return entity.Id == NotPersisted;
        }
    }
}
