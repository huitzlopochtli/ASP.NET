using MBP.Entity;
using System.Data.Entity;

namespace MVP.Data.Repository
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCatagory> BlogCatagories { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }


        public BlogDbContext()
            :base("name=MVPDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
