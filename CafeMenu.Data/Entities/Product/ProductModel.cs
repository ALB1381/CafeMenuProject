using CafeMenu.Data.Entities.Discount;
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
        public int ProducModelId { get; set; }

        [Display(Name = "Product Model Name")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(50, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(2, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public string ModelName { get; set; }

        public int ProductPrice { get; set; }

        public int ProductId { get; set; }

        public bool IsAvaible { get; set; }

        public int? AvaibleCount { get; set; }

        public int? DiscountId { get; set; }


        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public List<SubOrder> SubOrders { get; set; }

        [ForeignKey("DiscountId")]
        public ProductModelDiscount? ModelDiscount { get; set; }
    }
}
