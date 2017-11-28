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
    public class LoginRepository : Repository<Login>, ILoginRepository
    {
        public LoginRepository(DbContext context) : base(context)
        {
        }
        public BlogDbContext BlogDbContext => Context as BlogDbContext;

        public Login GetLoginByUsernameAndPassword(string username, string password)
        {
            Login login = BlogDbContext.Logins
                .SingleOrDefault(l => l.Username == username && l.Password == password);

            return login;
        }

        public ICollection<Blog> GetBlogByLogin(string url)
        {
            List<Blog> blogs = new List<Blog>();

            User user = BlogDbContext.Users.SingleOrDefault(u => u.Login.Username == url);

            blogs = BlogDbContext.Blogs.Where(b => b.User == user).ToList();

            return blogs;
        }
    }
}
