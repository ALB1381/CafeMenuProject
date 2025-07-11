using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Product
{
    public class ProductExteraConnection
    {
        [Key]
        public int ConnectionId { get; set; }

        public int ProductId { get; set; }

        public int ExtraProductId { get; set; }


        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("ExtraProductId")]
        public ExteraProduct ExteraProduct { get; set; }
    }
}
