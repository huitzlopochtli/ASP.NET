using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CodeFirst
{
    [NotMapped]
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataAccessContext();

            //LinQ Syntex
            //var query =
            //    from c in context.Courses
            //    where c.Name.Contains("C#")
            //    orderby c.Name
            //    select c;

            //Entension methods
            var query = context.Courses
                .Where(c => c.Name.Contains("C#"))
                .OrderBy(c => c.Name);

            foreach (var course in query)
            {
                Console.WriteLine(course.Name);
            }

            

            

        }
    }
}
  