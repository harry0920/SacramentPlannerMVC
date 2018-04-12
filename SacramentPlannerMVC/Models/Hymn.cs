using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlannerMVC.Models
{
    public partial class Hymn
    {
        public Hymn()
        {
            MeetingOpeningHymnNav = new HashSet<Meeting>();
            MeetingSacramentHymnNav = new HashSet<Meeting>();
            MeetingIntermediateHymnNav = new HashSet<Meeting>();
            MeetingClosingHymnNav = new HashSet<Meeting>();
        }

        public int ID { get; set; }

        [Display(Name = "Hymn Number")]
        public int HymnID { get; set; }

        public string HymnTitle { get; set; }

        public string HymnLabel
        {
            get
            {
                return HymnID + " - " + HymnTitle;
            }
        }

        public ICollection<Meeting> MeetingOpeningHymnNav { get; set; }
        public ICollection<Meeting> MeetingSacramentHymnNav { get; set; }
        public ICollection<Meeting> MeetingIntermediateHymnNav { get; set; }
        public ICollection<Meeting> MeetingClosingHymnNav { get; set; }
    }
}
