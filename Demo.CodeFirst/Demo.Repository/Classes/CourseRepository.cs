using System.Collections.Generic;
using Demo.CodeFirst;
using Demo.CodeFirst.Model;
using Demo.Repository.Interfaces;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;

namespace Demo.Repository.Classes
{
    class CourseRepository : Repository<Course>, ICourseRepository
    {
        

        public CourseRepository(DataAccessContext context) : base(context)
        {
        }
        //This field can also be initialised for easy accessing such as,
        //private DataAccessContext dataAccessContext = new DataAccessContext();
        public DataAccessContext DataAccessContext
        {
            get { return Context as DataAccessContext; }
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return DataAccessContext.Courses.OrderBy(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCourseWithAuthors(int pageIndex, int pageSize = 10)
        {
            return DataAccessContext.Courses
                .Include(c => c.Author)
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
