using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.User
{
    public class Permission
    {
        [Key]
        public int PermissionId { get; set; }

        [Display(Name = "Permission Title")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(80, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(3, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(80)")]
        public string PermissionTitle { get; set; }
    }
}
