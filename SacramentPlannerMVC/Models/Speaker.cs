using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlannerMVC.Models
{
    public partial class Speaker
    {
        public int ID { get; set; }

        public int MeetingID { get; set; }

        public string Name { get; set; }

        [StringLength(50)]
        [Required]
        public string Subject { get; set; }

        public Meeting Meeting { get; set; }
    }
}