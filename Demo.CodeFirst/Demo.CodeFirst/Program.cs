using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Demo.CodeFirst.Model;

namespace Demo.CodeFirst
{
    [NotMapped]
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataAccessContext();

            Console.WriteLine("Linq Syntex :"); 

            

            //LinQ Syntex
            var query1 =
                from c in context.Courses
                where c.Name.Contains("C#")
                orderby c.Name
                select c;

            //Entension methods
            var query2 = context.Courses
                .Where(c => c.Name.Contains("C#"))
                .OrderBy(c => c.Name);

            foreach (var course in query2)
            {
                Console.WriteLine(course.Name);
            }



            var query3 =
                from c in context.Courses
                where c.Level == CourseLevel.Beginner && c.Author.Id == 1
                orderby c.Level descending, c.Name
                select new { Name = c.Name, Author = c.Author };


            var query4 =
                from c in context.Courses
                group c by c.Level
                into g
                select g;
            foreach (var group in query4)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("{0} ({1})", group.Key, group.Count());
                foreach (var course in group)
                {
                    Console.WriteLine("\t{0}", course.Name);
                }
            }





            //Join with related tables
            var query5 =
                from c in context.Courses
                select new {CourseName = c.Name, AuthorName = c.Author.Name};


            //Join if no relation is between tables
            var query6 =
                from c in context.Courses
                join a in context.Authors on c.AuthorId equals a.Id
                select new { CourseName = c.Name, AuthorName = a.Name };

            foreach (var var in query6)
            {
                Console.WriteLine(var.AuthorName + " has "+ var.CourseName);
            }


            //Group Join
            var query7 =
                from a in context.Authors
                join c in context.Courses on a.Id equals c.AuthorId into g
                select new { AuthorName = a.Name, Course = g.Count() };

            foreach (var var in query7)
            {
                Console.WriteLine("{0} ({1})", var.AuthorName, var.Course);
            }

            //Cross Join
            var query8 =
                from a in context.Authors
                from c in context.Courses
                where a.Id == c.Author.Id
                select new {AuthorName = a.Name, CoureName = c.Name};

            foreach (var var in query8)
            {
                Console.WriteLine("{0} ({1})", var.AuthorName, var.CoureName);
            }



            //Entension method
            Console.WriteLine();
            Console.WriteLine("Entension method : ");

            var query10 = context.Courses
                .Where(c => c.Level == CourseLevel.Beginner)
                .OrderByDescending(c =>c.Name)
                .ThenBy(c => c.Level)
                .Select(c =>new{CourseName = c.Name, AuthorName = c.Author.Name});

            var query11 = context.Courses
                .Where(c => c.Level == CourseLevel.Beginner)
                .OrderByDescending(c => c.Name)
                .ThenBy(c => c.Level)
                .Select(c => c.Tags);

            foreach (var c in query11)
            {
                foreach (var tag in c)
                {
                    Console.WriteLine(tag.Name);
                }
            }

            var query12 = context.Courses
                .Where(c => c.Level == CourseLevel.Beginner)
                .OrderByDescending(c => c.Name)
                .ThenBy(c => c.Level)
                .SelectMany(c => c.Tags)
                .Distinct();

            foreach (var t in query12)
            {
                    Console.WriteLine(t.Name);    
            }


            var query13 = context.Courses
                .GroupBy(c => c.Level);
            foreach (var group in query13)
            {
                Console.WriteLine(group.Key);
                foreach (var course in group)
                {
                    Console.WriteLine("\t" + course.Name);
                }
            }

            

            //InnerJoin
            var query14 = context.Courses
                .Join(context.Authors, 
                c => c.AuthorId, 
                a => a.Id, 
                (course, author) => new
                {
                    CourseName = course.Name,
                    AuthorName = author.Name
                });

            //Group Join
            var query15 = context.Authors
                .GroupJoin(context.Courses, a => a.Id, c => c.AuthorId, (author, courses) => new
                {
                    AuthorName = author.Name,
                    Courses = courses
                });

            foreach (var author in query15)
            {
                Console.WriteLine(author.AuthorName);
                foreach (var course in author.Courses)
                {
                    Console.WriteLine("\t" + course.Name);
                }
            }


            //CrossJoin
            var query16 = context.Authors
                .SelectMany(
                a => context.Courses, 
                (author, course) => new
            {
                AuthorName = author.Name,
                CourseName = course.Name
            });
            foreach (var e in query16)
            {
                Console.WriteLine(e.AuthorName +" " + e.CourseName);
            }

            Console.Clear();


            //Partitioning
            Console.WriteLine("Partitioning : ");
            var query17 = context.Courses.Skip(10).Take(10);
            //foreach (var e in query17)
            //{
            //    Console.WriteLine(e.Name);
            //}



            //Element Operators
            Console.WriteLine("Element Operators : ");
            var query18 = context.Courses.OrderBy(c => c.Level).FirstOrDefault(c =>c.FullPrice > 100);
            var query19 = context.Courses.SingleOrDefault(c => c.Id == 1);


            //Quantifying
            var aboveAll100 =context.Courses.All(c => c.FullPrice > 10);
            var isId2Exist = context.Courses.Any(c => c.Id == 2);


            //Aggregating
            var count = context.Courses.Count();
            var max = context.Courses.Max(c => c.FullPrice);
            var min = context.Courses.Min(c => c.FullPrice);
            var avg = context.Courses.Average(c => c.FullPrice);

            var countLevel1 = context.Courses.Count(c => c.Level == CourseLevel.Beginner);
            //var countLevel1 = context.Courses.Where(c => c.Level == CourseLevel.Beginner).Count();
        }
    }
}
  