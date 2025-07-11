using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Product
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string? ProductDescription { get; set; }
        public string? ProductIngredients { get; set; }

        public int ProductGroupId { get; set; }

        public int ProductSubGroupId { get; set; }

        public string ProductImage { get; set; }






        [ForeignKey("ProductGroupId")]
        public ProductGroup ProductGroup { get; set; }
        
        [ForeignKey("ProductSubGroupId")]
        public ProductGroup? ProductSubGroup { get; set; }

        public List<ProductModel> Models { get; set; }

        public List<ProductExteraConnection> ProductExteraConnections { get; set; }

    }
}
