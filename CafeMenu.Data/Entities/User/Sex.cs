using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.User
{
    public class Sex
    {
        [Key]
        public int SexId { get; set; }

        [Display(Name = "Name of sex")]
        [Required(ErrorMessage = "Please enter the {0}")]
        [MaxLength(20, ErrorMessage = "The {0} Should be less then {1}")]
        [MinLength(3, ErrorMessage = "The {0} Should be More then {1}")]
        [Column(TypeName = "nvarchar(20)")]
        public string SexName { get; set; }

        public List<User> Users { get; set; }
    }
}
