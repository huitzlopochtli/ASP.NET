using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.CodeFirst.Model;
using Demo.CodeFirst.Model_Configuration;

namespace Demo.CodeFirst
{
    class DataAccessContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DataAccessContext()
            :base("name=DemoEntityFrameworkCodeFirst")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());





            base.OnModelCreating(modelBuilder);
        }
    }
}
