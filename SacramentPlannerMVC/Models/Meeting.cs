﻿using System;
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
        
        [Range(1, 341)]
        [Display(Name = "Opening Hymn")]
        [Required]
        public int OpeningHymn { get; set; }

        [Range(1, 341)]
        [Display(Name = "Sacrament Hymn")]
        [Required]
        public int SacramentHymn { get; set; }

        [Range(1, 341)]
        [Display(Name = "Intermediate Hymn")]
        public int? IntermediateHymn { get; set; }

        [Range(1, 341)]
        [Display(Name = "Closing Hymn")]
        [Required]
        public int ClosingHymn { get; set; }
        
        [Display(Name = "Opening Prayer")]
        [StringLength(100)]
        [Required]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        [StringLength(100)]
        [Required]
        public string ClosingPrayer { get; set; }

        public int BishopricID { get; set; }
        [Required]
        public Bishopric Conductor { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
    }
}
