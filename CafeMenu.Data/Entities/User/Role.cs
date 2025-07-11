using CafeMenu.Data.Entities.User.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.User
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Display(Name = "Name Role")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(80, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(3, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(80)")]
        public string RoleName { get; set; }









        public List<RolePermissionConnection> RolePermissionConnections { get; set; }
        public List<User> Users { get; set; }
    }
}
