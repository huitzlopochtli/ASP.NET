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

        }
    }
}
  