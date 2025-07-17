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

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(50, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(2, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public string ProductName { get; set; }

        [Display(Name = "Product Description")]
        [MaxLength(200, ErrorMessage = "The {0} Should be less then {1}")]
        [Column(TypeName = "nvarchar(200)")]
        public string? ProductDescription { get; set; }


        public string? ProductIngredients { get; set; }

        public int ProductGroupId { get; set; }

        public int? ProductSubGroupId { get; set; }


        [Display(Name = "Product Image")]
        [MaxLength(200, ErrorMessage = "The {0} Should be less then {1}")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [Column(TypeName = "nvarchar(200)")]
        public string ProductImage { get; set; }


        [ForeignKey("ProductGroupId")]
        public ProductGroup ProductGroup { get; set; }
        
        [ForeignKey("ProductSubGroupId")]
        public ProductGroup? ProductSubGroup { get; set; }

        public List<ProductModel> Models { get; set; }

        public List<ProductExteraConnection> ProductExteraConnections { get; set; }

    }
}
