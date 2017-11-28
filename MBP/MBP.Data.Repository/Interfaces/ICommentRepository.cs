using System;
using System.Collections.Generic;
using System.Text;
using MBP.Entity;

namespace MBP.Data.Repository.Interfaces
{
    public interface ICommentRepository : IRepository<Comment>
    {
        ICollection<Comment> GetCommentsByBlog(Blog blog);
        ICollection<Comment> GetCommentsByBlog(int blogId);
    }
}
