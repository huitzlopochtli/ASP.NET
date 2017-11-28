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
    public class BlogTypeRepository : Repository<BlogType> , IBlogTypeRepository
    {
        public BlogTypeRepository(DbContext context) : base(context)
        {
        }

        public BlogType GetByUrl(string url)
        {
            BlogType blogType = BlogDbContext.BlogTypes.Include(bt => bt.Blogs).SingleOrDefault(bt => bt.Url == url);
            return blogType;
        }
    }
}
