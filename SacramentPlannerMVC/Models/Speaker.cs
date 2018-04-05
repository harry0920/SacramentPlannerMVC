using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlannerMVC.Models
{
    public class Speaker
    {
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [Required]
        public string Subject { get; set; }

        [Required]
        public Meeting Meeting { get; set; }
    }
}
