using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Application.Orm.Entity
{
    public class Salle : BaseEntity
    {
        public int ProductID { get; set; }
        public int UserID { get; set; } 

        public virtual Product Product { get; set; }
        public virtual User User { get; set; }

        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public double FaturaTutari { get; set; }
    }
}
