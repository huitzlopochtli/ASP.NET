using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.CodeFirst;
using Demo.Repository.Interfaces;

namespace Demo.Repository.Classes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataAccessContext _context;

        public UnitOfWork(DataAccessContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Authors = new AuthorRepository(_context);
        }

        public ICourseRepository Courses { get; private set; }

        public IAuthorRepository Authors { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
