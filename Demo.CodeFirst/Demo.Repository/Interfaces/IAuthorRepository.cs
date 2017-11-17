using Demo.CodeFirst.Model;

namespace Demo.Repository.Interfaces
{
    public interface IAuthorRepository
    {
        Author GetAuthorWithCourses(int id);
    }
}
