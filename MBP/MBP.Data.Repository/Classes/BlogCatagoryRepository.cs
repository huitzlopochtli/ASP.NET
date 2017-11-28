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
    class BlogCatagoryRepository : Repository<BlogCatagory> , IBlogCatagoryRepository
    {
        public BlogCatagoryRepository(DbContext context) : base(context)
        {
        }
        public BlogDbContext BlogDbContext => Context as BlogDbContext;

        public BlogCatagory GetBuyUrl(string url)
        {
            BlogCatagory blogCatagory = BlogDbContext.BlogCatagories.Include(bc => bc.Blogs)
                .SingleOrDefault(bc => bc.Url == url);
            return blogCatagory;
        }
    }
}
