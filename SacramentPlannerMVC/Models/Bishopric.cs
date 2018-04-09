﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlannerMVC.Models
{
    public class Bishopric
    {
        public int ID { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
