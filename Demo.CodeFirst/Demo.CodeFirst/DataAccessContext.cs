using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.CodeFirst.Model;

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
            modelBuilder.Entity<Course>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Course>()
                .Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(2000);

            modelBuilder.Entity<Course>()
                .HasRequired(c => c.Author)
                .WithMany(a => a.Courses)
                .HasForeignKey(c => c.AuthorId)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Course>()
                .HasMany(c => c.Tags)
                .WithMany(t => t.Courses)
                .Map(m => m.ToTable("CourseTags"));


            modelBuilder.Entity<Course>()
                .HasRequired(c => c.Cover)
                .WithRequiredPrincipal(c => c.Course);


            base.OnModelCreating(modelBuilder);
        }
    }
}
