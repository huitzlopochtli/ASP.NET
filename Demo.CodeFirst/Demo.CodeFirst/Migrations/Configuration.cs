using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Demo.CodeFirst.Model;

namespace Demo.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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

            var tags = new Dictionary<string, Tag>()
            {
                {"C#",new Tag(){Id = 1, Name = "C#"} },
                {"angularjs",new Tag(){Id = 1, Name = "angularjs"} },
                {"javaScript",new Tag(){Id = 1, Name = "javaScript"} },
                {"nodejs",new Tag(){Id = 1, Name = "nodejs"} },
                {"oop",new Tag(){Id = 1, Name = "oop"} },
                {"linQ",new Tag(){Id = 1, Name = "linQ"} },
            };
            foreach (var tag in tags.Values)
            {
                context.Tags.AddOrUpdate(t => t.Id, tag);
                
            }



            var authors = new List<Author>()
            {
                new Author(){Id = 1, Name = "Peeyal Khondokar"},
                new Author(){Id = 2, Name = "Nasim Anjum"},
                new Author(){Id = 3, Name = "Sajid Abdullah"},
                new Author(){Id = 4, Name = "Rifat Suvro"},
            };
            foreach (var author in authors)
            {
                context.Authors.AddOrUpdate(a => a.Id, author);

            }

            var courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Name = "Basic of C#",
                    Author = authors[0], Description = "Description of C#",
                    FullPrice = 49,
                    Level = CourseLevel.Beginner,
                    Tags = new Collection<Tag>()
                    {
                        tags["C#"]
                    }
                },

                new Course()
                {
                    Id = 2,
                    Name = "Basic of Angular JS",
                    Author = authors[0], Description = "Description of Angular JS",
                    FullPrice = 49,
                    Level = CourseLevel.Beginner,
                    Tags = new Collection<Tag>()
                    {
                        tags["angularjs"]
                    }},
                new Course()
                {
                    Id = 3,
                    Name = "Basic of JavaScript",
                    Author = authors[0], Description = "Description of JavaScript",
                    FullPrice = 49,
                    Level = CourseLevel.Beginner,
                    Tags = new Collection<Tag>()
                    {
                        tags["javaScript"]
                    }
                },
                new Course()
                {
                    Id = 4,
                    Name = "Basic of LinQ",
                    Author = authors[0], Description = "Description of LinQ",
                    FullPrice = 49,
                    Level = CourseLevel.Beginner,
                    Tags = new Collection<Tag>()
                    {
                        tags["linQ"]
                    }
                },
            };

            foreach (var course in courses)
            {
                context.Courses.AddOrUpdate(a => a.Id, course);

            }

        }
    }
}
