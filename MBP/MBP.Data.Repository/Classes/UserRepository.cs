using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MBP.Data.Repository.Interfaces;
using MBP.Entity;
using MBP.Models;
using MVP.Data.Repository;

namespace MBP.Data.Repository.Classes
{
    class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
        


        public BlogUserViewModel GetByUrl(string url)
        {
            User user = BlogDbContext.Users.SingleOrDefault(u => u.Url == url);

            List<Blog> blogs = new List<Blog>();
            blogs = BlogDbContext.Blogs.Where(b => b.UserId == user.Id).ToList();


            return new BlogUserViewModel()
            {
                User = new User()
                {
                    Fullname = user.Fullname,
                    Mobile = user.Mobile,
                    Email = user.Mobile,
                    Address = user.Address,
                    DateTime = user.DateTime
                },

                Blogs = blogs
            };
        }
    }
}
