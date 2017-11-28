using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MBP.Data.Repository.Interfaces;
using MBP.Entity;
using MVP.Data.Repository;

namespace MBP.Data.Repository.Classes
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context) : base(context)
        {

        }

        public ICollection<Comment> GetCommentsByBlog(Blog blog)
        {
            List<Comment> comments = BlogDbContext.Comments.Include(c => c.Blog == blog).ToList();
            return comments ?? null;
        }

        public ICollection<Comment> GetCommentsByBlog(int blogId)
        {
            List<Comment> comments = BlogDbContext.Comments.Include(c => c.BlogId == blogId).ToList();
            return comments ?? null;
        }
    }
}
