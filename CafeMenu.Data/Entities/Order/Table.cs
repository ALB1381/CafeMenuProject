﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Order
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }

        public int TableCount { get; set; }

     
        [Column(TypeName = "nvarchar(50)")]
        public string? TableIcon { get; set; }

        public List<Order> Orders { get; set; }
    }
}
