using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Product
{
    public class ExteraProduct
    {
        [Key]
        public int EPId { get; set; }

        public string ExteraOnItemTitle { get; set; }

        public int Price { get; set; }

        public List<ExteraProductSubOrderConnection> ExteraProductSubOrderConnections { get; set; }

        public List<ProductExteraConnection> ProductExteraConnections { get; set; }
    }
}
