using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTaskBootstrapLumia.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Fullname { get; set; }
        public string Profession { get; set; }
        public List<Comment> Comment { get; set; }
    }
}
