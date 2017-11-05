using System.Collections.Generic;
using Demo.CodeFirst.Model;

namespace Demo.CodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Demo.CodeFirst.DataAccessContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Demo.CodeFirst.DataAccessContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Authors.AddOrUpdate(
               a => a.Name,
               new Author()
               {
                   Name = "Author 1",
                   Courses = new List<Course>()
                   {
                       new Course()
                       {
                           Name = "Course1 for Author 1",
                           Description = "Description"
                       },
                       new Course()
                       {
                           Name = "Course2 for Author 1",
                           Description = "Description"
                       }
                   }
               }
              );
        }
    }
}
