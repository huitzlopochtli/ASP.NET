using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MBP.Data.Repository.Interfaces;
using MBP.Entity;
using MVP.Data.Repository;

namespace MBP.Data.Repository.Classes
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(DbContext context) : base(context)
        {
        }

        public BlogDbContext BlogDbContext => Context as BlogDbContext;

        public Blog GetBuyUrl(string url)
        {
            Blog blog = BlogDbContext.Blogs.SingleOrDefault(b => b.Url == url) as Blog;
            return blog;
        }
    }
}
