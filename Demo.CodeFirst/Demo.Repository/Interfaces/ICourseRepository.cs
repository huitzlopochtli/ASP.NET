using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Demo.CodeFirst.Model;

namespace Demo.Repository.Interfaces
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCourseWithAuthors(int pageIndex, int pageSize);
    }
}
