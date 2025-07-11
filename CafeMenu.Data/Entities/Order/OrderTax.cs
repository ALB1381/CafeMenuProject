using CafeMenu.Data.Entities.User.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Order
{
    public class OrderTax
    {
        [Key]
        public int TaxId { get; set; }

        [Required]
        [DataType("tinyint")]
        [Range(1,100)]
        public int Percentage { get; set; }


        public List<Order> Orders { get; set; }
    }
}
