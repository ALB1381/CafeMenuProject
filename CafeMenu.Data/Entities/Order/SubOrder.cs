using CafeMenu.Data.Entities.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Order
{
    public class SubOrder
    {

        [Key]
        public int SubOrderId { get; set; }

        [Range(1,100)]
        public int Count { get; set; }

        public int ProductModelId { get; set; }

        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("ProductModelId")]
        public ProductModel ProductModel { get; set; }

        public List<ExteraProductSubOrderConnection>? ExteraProductSubOrderConnections { get; set; }

    }
}
