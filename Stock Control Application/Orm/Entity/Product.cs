using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Control_Application.Orm.Entity
{
    public class Product : BaseEntity
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Quantity { get; set; } //miktar
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Supplier { get; set; } //tedarikçi
        [Required]
        public string Description { get; set; } //tanım
        public string ImageUrl { get; set; }

        List<User> Users = new List<User>();
    }
}
