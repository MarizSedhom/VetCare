using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string WorkingHours { get; set; }
        public int ExaminationPrice { get; set; }
    }
}