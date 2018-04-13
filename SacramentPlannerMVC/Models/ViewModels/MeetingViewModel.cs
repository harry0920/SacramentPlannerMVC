using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlannerMVC.Models.ViewModels
{
    public class MeetingViewModel
    {
        public IEnumerable<Meeting> Meetings { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
        public Speaker Speaker { get; set; }
    }
}
