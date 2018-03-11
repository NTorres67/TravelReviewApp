using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelRevewApp.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Display(Name = "Location or Organization")]
        public string Name { get; set; }
        [Display(Name = "Arrival Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Arrive { get; set; }
        [Display(Name = "Departure Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Depart { get; set; }
        public bool Sunny { get; set; }
        [Display(Name = "Rate (1-5)")]
        public string Rating { get; set; }
        public string Comments { get; set; }
        

        //Foreign Keys and Navigation Properties\
        [ForeignKey("Category"), Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}