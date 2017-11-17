using Demo.CodeFirst.Model;

namespace Demo.Repository.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithCourses(int id);
    }
}
