using CafeMenu.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Customers
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "User name")]
        [MaxLength(50, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(3, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public string? UserName { get; set; }

        [Display(Name = "User first name and last name")]
        [MaxLength(50, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(3, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public string? UserFNameLName { get; set; }

        [Display(Name = "Age")]
        [Range(1, 120, ErrorMessage = "The {0} Should be between {1} and {2}")]
        [Column(TypeName = "tinyint")]
        public int? Age { get; set; }

        [Display(Name = "Email")]
        [MaxLength(100, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(10, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(100)")]
        public string? Email { get; set; }
        public DateTime MadeDate { get; set; } = DateTime.Now;


        [Column(TypeName = "int")]
        public int? CountOfOrders { get; set; }


        [Column(TypeName = "bigint")]
        public Int64 SumOfOrders { get; set; }


        [Display(Name = "Address")]
        [MaxLength(800, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(10, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(800)")]
        public string? Address { get; set; }




        public List<Order.Order> Orders { get; set; }
        public int? SexId  { get; set; }
        [ForeignKey("SexId")]
        public CustomerSex? Sex { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
