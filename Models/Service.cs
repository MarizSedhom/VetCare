using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Icon { get; set; }
        public string PathIcon { get; set; }
        public string PathIcon2 { get; set; }

    }
}