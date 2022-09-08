using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Support.Models
{
    public class Pet
    {
        public int Id { get; set; }
        
        [Display(Name = "Pet Name")]
        public string Name { get; set; }
        [Display(Name = "Pet Type")]
        public string Type { get; set; }
        [Display(Name = "Pet Age")]
        public int Age { get; set; }
        public Doctor Doctor { get; set; }
        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }
        public Customers Customers { get; set; }
        public int CustomersId { get; set; }
        public Service Services { get; set; }
        [Display(Name = "Service")]
        public int ServicesId { get; set; }

    }
}