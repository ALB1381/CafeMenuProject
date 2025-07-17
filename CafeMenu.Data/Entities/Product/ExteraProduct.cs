using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Product
{
    public class ExteraProduct
    {
        [Key]
        public int EPId { get; set; }

        [Display(Name = "Extera Product Name")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(70, ErrorMessage = "The {0} Should be less then {1}")]
        [Column(TypeName = "nvarchar(70)")]
        public string ExteraOnItemTitle { get; set; }

        public int Price { get; set; }

        public List<ExteraProductSubOrderConnection>? ExteraProductSubOrderConnections { get; set; }

        public List<ProductExteraConnection>? ProductExteraConnections { get; set; }
    }
}
