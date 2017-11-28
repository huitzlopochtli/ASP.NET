using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MBP.Entity;

namespace MBP.Models
{
    public class BlogUserViewModel
    {
        public User User { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}