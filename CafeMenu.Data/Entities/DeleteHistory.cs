using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities
{
    public class DeleteHistory
    {
        [Key]
        public int Id { get; set; }

        public int DeletedId { get; set; }

        public DateTime DeletedDate { get; set; } = DateTime.Now;

        [DataType("nvaechat(80)")]
        public string DeletedTableName { get; set; }

    }
}
