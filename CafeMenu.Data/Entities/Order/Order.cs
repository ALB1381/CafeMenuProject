using CafeMenu.Data.Entities.Customers;
using CafeMenu.Data.Entities.Discount;
using CafeMenu.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Order
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        

        public DateTime OrderDate { get; set; } 

        public int? OrderTotalSum { get; set; }
        public int? OrderRawSum { get; set; }
        public int? OrderTransportSum { get; set; }
        public int? TaxPrice { get; set; }

        [Display(Name = "Order Description")]
        [MaxLength(800, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(10, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(800)")]
        public string? OrderDescription { get; set; }

        [Display(Name = "Address")]
        [MaxLength(800, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(10, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(800)")]
        public string? Address { get; set; }

        public int TaxId { get; set; }

        public int DiscountId { get; set; }
        public int CustomerId { get; set; }
        public int OrderTypeId { get; set; }
        public int? TableId { get; set; }

        public Boolean IsPayed { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [ForeignKey("DiscountId")]
        public OrderDiscount OrderDiscount { get; set; }

        [ForeignKey("OrderTypeId")]
        public OrderType OrderType { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }

        [ForeignKey("TaxId")]
        public OrderTax OrderTax { get; set; }

        public List<SubOrder> SubOrders { get; set; }

    }
}
