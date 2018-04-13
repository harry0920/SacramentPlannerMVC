using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlannerMVC.Models.ViewModels
{
    public class MeetingDetailView
    {
        public Meeting Meeting { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
        public Speaker Speaker { get; set; }
        public Bishopric Conductor { get; set; }
    }
}
