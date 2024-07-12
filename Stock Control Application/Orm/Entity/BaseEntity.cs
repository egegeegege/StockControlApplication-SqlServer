using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Application.Orm.Entity
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime? AddDate = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        [Required]
        public bool AktifMi { get; set; }
    }
}
