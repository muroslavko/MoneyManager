using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Db.Entity
{
    public class Person : BaseEntity
    {
        public Person()
        {
            Transactions = new List<Transaction>();
        }
        public string Name { get; set; }

        public double Balance { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
