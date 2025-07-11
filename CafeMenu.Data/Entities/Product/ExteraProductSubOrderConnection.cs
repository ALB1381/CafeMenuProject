using CafeMenu.Data.Entities.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Product
{
    public class ExteraProductSubOrderConnection
    {
        [Key]
        public int ConnectionId { get; set; }

        public int SubOrderId { get; set; }
        public int ExtraProductId { get; set; }

        [ForeignKey("SubOrderId")]
        public SubOrder SubOrder { get; set; }

        [ForeignKey("ExtraProductId")]
        public ExteraProduct ExteraProduct { get; set; }
    }
}
