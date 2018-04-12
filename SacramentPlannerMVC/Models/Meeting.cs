using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlannerMVC.Models
{
    public partial class Meeting
    {
        public Meeting()
        {
            Speakers = new HashSet<Speaker>();
        }

        public int MeetingId { get; set; }

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
        [Display(Name = "Conductor")]
        public int BishopricID { get; set; }
        public Bishopric Conductor { get; set; }

        [Display(Name = "Opening Hymn")]
        public int OpeningHymnID { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public int SacramentHymnID { get; set; }

        [Display(Name = "Intermediate Hymn")]
        public int? IntermediateHymnID { get; set; }

        [Display(Name = "Closing Hymn")]
        public int ClosingHymnID { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
        public Hymn OpeningHymnNav { get; set; }
        public Hymn SacramentHymnNav { get; set; }
        public Hymn IntermediateHymnNav { get; set; }
        public Hymn ClosingHymnNav { get; set; }
    }
}
