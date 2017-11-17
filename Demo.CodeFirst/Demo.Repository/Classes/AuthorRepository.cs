using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.CodeFirst;
using Demo.CodeFirst.Model;
using Demo.Repository.Interfaces;

namespace Demo.Repository.Classes
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(DbContext context) : base(context)
        {
        }

        public DataAccessContext DataAccessContext {
            get { return Context as DataAccessContext; } }

        public Author GetAuthorWithCourses(int id)
        {
            return DataAccessContext.Authors.Include(a => a.Courses).SingleOrDefault(a => a.Id == id);
        }
    }
}
