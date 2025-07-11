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

        [Display(Name = "Age")]
        [Column(TypeName = "Tinyint")]
        [Range(1, 120, ErrorMessage = "The {0} Should be between {1} and {2}")]
        public int? Age { get; set; }

        [Display(Name = "User Full Name")]
        [MaxLength(50, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(3, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(50)")]
        public string? UseFullName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(80, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(8, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(80)")]
        public string Password { get; set; }

        [Display(Name = "National Code")]
        [MaxLength(30, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(3, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(30)")]
        public string? NationalCode { get; set; }

        [Display(Name = "Email")]
        [MaxLength(100, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(10, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(100)")]
        public string? Email { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(15, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(10, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(15)")]
        public string PhoneNumber { get; set; }
         
        public string ActiveCodeForPhoneNumber { get; set; }
        public string? ActiveCodeForEmail { get; set; }

        [Display(Name = "Address")]
        [MaxLength(800, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(8, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(800)")]
        public string? Address { get; set; }
        public bool TotalIsActive { get; set; }
        public bool PhoneNumberIsActived { get; set; }
        public bool EmailIsActived { get; set; }


        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public int SexId { get; set; }
        [ForeignKey("SexId")]
        public Sex Sex { get; set; }
    }
}
