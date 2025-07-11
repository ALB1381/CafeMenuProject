using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Order
{
    public class OrderType
    {
        [Key]
        public int TypeId { get; set; }

        [Display(Name = "Title of type")]
        [MaxLength(50, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(2, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage ="{0} is required")]
        public string TypeTitle { get; set; }

        public List<Order> Orders { get; set; }
    }
}
