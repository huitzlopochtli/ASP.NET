using System;
using System.Collections.Generic;

namespace MBP.Entity
{
    public class BlogCatagory
    {
        public int? Id { get; set; }
        public string Description { get; set; }

        public string Url { get; set; }

        public string Content { get; set; }
        public string Title { get; set; }

        public ICollection<Blog> Blogs { get; set; }


        public DateTime DateTime { get; set; }

        public bool IsDeleted { get; set; }

        public BlogCatagory()
        {
            Blogs = new HashSet<Blog>();
        }
    }
}
