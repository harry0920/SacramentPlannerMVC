using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlannerMVC.Models.ViewModels
{
    public class SpeakerViewModel
    {
        public Meeting Meeting { get; set; }
        public Speaker Speaker { get; set; }
    }
}
