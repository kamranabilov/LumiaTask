using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTaskBootstrapLumia.Models
{
    public class Testimonials
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int CommentId { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
