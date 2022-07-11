using HomeTaskBootstrapLumia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTaskBootstrapLumia.ViewModels
{
    public class HomeVM
    {
        public List<Testimonials> Testimonials { get; set; }
        public List<Comment> Comment { get; set; }
        public List<User> User { get; set; }
        public List<Home> Home { get; set; }
        public List<Contact> Contact { get; set; }
    }
}
