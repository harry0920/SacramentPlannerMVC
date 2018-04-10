using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlannerMVC.Models
{
    public class Bishopric: Member
    {
      
        [Required]
        public bool IsActive { get; set; }

       
    }
}
