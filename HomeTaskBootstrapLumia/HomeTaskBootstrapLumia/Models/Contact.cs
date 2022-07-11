using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTaskBootstrapLumia.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Call { get; set; }
    }
}
