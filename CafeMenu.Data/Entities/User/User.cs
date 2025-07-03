using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CafeMenu.Data.Entities.User
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name ="User name")]
        [Required(ErrorMessage ="Please enter the {0}")]
        [MaxLength(50,ErrorMessage ="The {0} Should be less then {1}")]
        [MinLength(3,ErrorMessage ="The {0} Should be More then {1}")]
        [Column(TypeName ="nvarchar(50)")]
        public string UserName { get; set; }
        public int? Age { get; set; }
        public string? UseFullName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(80, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(8, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(80)")]
        public string Password { get; set; }
        public string? NationalCode { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ActiveCodeForPhoneNumber { get; set; }
        public string? ActiveCodeForEmail { get; set; }
        public string? Address { get; set; }
        public bool TotalIsActive { get; set; }
        public bool PhoneNumberIsActived { get; set; }
        public bool EmailIsActived { get; set; }



        public Sex SexId { get; set; }
    }
}
