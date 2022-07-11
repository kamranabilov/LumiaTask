using HomeTaskBootstrapLumia.DAL;
using HomeTaskBootstrapLumia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTaskBootstrapLumia.Controllers
{
    public class HomeController:Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Testimonials> testimonials = _context.Testimonials.ToList();
            return View(testimonials);
        }
    }
}
