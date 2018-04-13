using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlannerMVC.Models
{
    public class MeetingIndexModel
    {
        public IEnumerable<Meeting> Meetings { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
        public Speaker Speaker { get; set; }
    }
}
