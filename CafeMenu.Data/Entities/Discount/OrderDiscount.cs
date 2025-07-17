using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Discount
{
    public class OrderDiscount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiscountId { get; set; }


        [Display(Name = "DiscountCode")]
        [MaxLength(120, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(10, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(120)")]
        public string DiscountCode { get; set; }

        public int MaxCountOfUsage { get; set; }

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public List<Order.Order> Orders { get; set; }


    }
}
