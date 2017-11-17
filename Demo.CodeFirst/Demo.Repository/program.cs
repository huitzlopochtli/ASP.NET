using Demo.CodeFirst;
using Demo.Repository.Classes;

namespace Demo.Repository
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new DataAccessContext()))
            {
                //Example 1
                var course = unitOfWork.Courses.Get(1);

                //Example 2
                var courses = unitOfWork.Courses.GetCourseWithAuthors(1, 4);

                //Example 3 For Cascade Delete
                var author = unitOfWork.Authors.GetAuthorWithCourses(1);
                unitOfWork.Courses.RemoveRange(author.Courses);
                unitOfWork.Authors.Remove(author);
            }
        }
    }
}
