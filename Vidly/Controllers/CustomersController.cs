using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    [RoutePrefix("customers")]
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("/")]
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType);
            return View(customers);
        }

        [Route("details/{id: int}")]
        public ActionResult Details(int? id)
        {
                var cst = _context.Customers.SingleOrDefault(c => c.Id == id);
                if (cst != null)
                {
                    return View(cst);
                }
                return HttpNotFound();
        }
    }
}