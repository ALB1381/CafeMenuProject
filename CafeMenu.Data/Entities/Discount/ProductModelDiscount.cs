using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Discount
{
    public class ProductModelDiscount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiscountId { get; set; }



        [Display(Name = "Event")]
        [MaxLength(800, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(10, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(800)")]
        public string? Event { get; set; }

        [Range(1, 100, ErrorMessage = "The {0} Should be between {1} and {2}")]
        [Column(TypeName = "tinyint")]
        public int Percentage { get; set; }

        public List<Product.ProductModel>? ProductModels { get; set; }
    }
}
