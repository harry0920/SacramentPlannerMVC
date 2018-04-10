using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlannerMVC.Models
{
    public class Speaker: Member
    {
        [StringLength(50)]
        [Required]
        public string Subject { get; set; }
    }
}