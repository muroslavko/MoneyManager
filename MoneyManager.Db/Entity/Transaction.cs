using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Db.Entity
{
    public class Transaction : BaseEntity
    {
        //TODO figure out if its useful
        //public double Balance { get; set; }

        public double Amount { get; set; }

        public string Comment { get; set; }

        //public DateTime Time { get; set; }

        public virtual Person Person { get; set; }
    }
}
