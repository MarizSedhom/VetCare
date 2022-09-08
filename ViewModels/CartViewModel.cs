using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Support.Models;

namespace Support.ViewModels
{
    public class CartViewModel
    {
        public Shopping Shoppings { get; set; }
        public Cart Cart { get; set; }
        
    }
}