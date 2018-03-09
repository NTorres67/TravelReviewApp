using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelRevewApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Type { get; set; }

        // Navigation Property
        public virtual ICollection<Review> Reviews { get; set; }
    }
}