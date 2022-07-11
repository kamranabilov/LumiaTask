using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTaskBootstrapLumia.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
