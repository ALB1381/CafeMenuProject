using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Product
{
    public class ProductGroup
    {
        [Key]
        public int GroupId { get; set; }

        [Display(Name = "Group Name")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(50, ErrorMessage = "The {0} Should be less then {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public string GroupName { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public List<ProductGroup>? ProducParenttGroups { get; set; }

        [InverseProperty("ProductGroup")]
        public List<Product> Products { get; set; }

        [InverseProperty("ProductSubGroup")]
        public List<Product>? SubProducts { get; set; }
    }
}
