using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Support.Models;
using Support.ViewModels;

namespace Support.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Appointment()
        {
            var doctors = _context.Doctors.ToList();
            var services = _context.Services.ToList();
            var viewModel = new AppointmentViewModel()
            {
                Doctors = doctors,
                Services = services
            };
            return View(viewModel);
        }

        public ActionResult Save(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
            return RedirectToAction("Services", "Home");
        }
        
        public ActionResult Cart(Shopping s)
        {
            if (s.Id == 0)
            {
                return HttpNotFound();
            }
                var shopping = _context.Shoppings.SingleOrDefault(c => c.Id == s.Id);
                var viewModel = new CartViewModel
                {
                    Shoppings = shopping
                };

                return View(viewModel);
            }
        
        public ActionResult Check(Cart cart)
        {
            

            _context.Carts.Add(cart);
            _context.SaveChanges();

            return RedirectToAction("Shop","Home");
        }
    }
}