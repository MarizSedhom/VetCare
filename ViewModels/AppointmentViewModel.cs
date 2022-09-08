using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Support.Models;

namespace Support.ViewModels
{
    public class AppointmentViewModel
    {
       public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
       public Pet Pet { get; set; }
        

    }
}