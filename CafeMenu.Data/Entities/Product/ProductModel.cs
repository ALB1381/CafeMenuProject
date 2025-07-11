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
    public class ProductModel
    {
        [Key]
        public int ProducModel { get; set; }

        public string ModelName { get; set; }

        public int ProductPrice { get; set; }

        public int ProductId { get; set; }

        public bool IsAvaible { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public List<SubOrder> SubOrders { get; set; }
    }
}
