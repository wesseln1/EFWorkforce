﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFWorkForce.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        [Display(Name = "Purchase Date")]
        public DateTime PurchaseDate { get; set; }
        [Display(Name = "Decomission Date")]
        public DateTime? DecomissionDate { get; set; }
        public Employee Employee { get; set; }
    }
}
