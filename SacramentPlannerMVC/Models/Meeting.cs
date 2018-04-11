using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlannerMVC.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Meeting Date")]
        public DateTime Date { get; set; }
                
        [Display(Name = "Opening Prayer")]
        [StringLength(100)]
        [Required]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        [StringLength(100)]
        [Required]
        public string ClosingPrayer { get; set; }

        [Required]
        public int BishopricID { get; set; }
        public Bishopric Conductor { get; set; }

        public ICollection<Speaker> Speakers { get; set; }

        public int OpeningHymnID { get; set; }
        public int SacramentHymnID { get; set; }
        public int IntermediateHymnID { get; set; }
        public int ClosingHymnID { get; set; }
        public Hymn Hymn { get; set; }
    }
}
