using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlannerMVC.Models
{
    public partial class Bishopric
    {
        public int BishopricId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public ICollection<Meeting> Meeting { get; set; }
        
    }
}
