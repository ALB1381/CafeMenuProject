using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Customers
{
    public class PhoneNumber
    {
        [Key]
        public int PhoneId { get; set; }

        [Display(Name = "Phone number")]
        [MaxLength(20, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(3, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Please enter the {0}")]
        public string Number { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
