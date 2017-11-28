using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBP.Entity
{
    public class Comment
    {
        public int? Id { get; set; }

        public Blog Blog { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }

        public User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public int? CommentParent { get; set; }

        public string Url { get; set; }

        public string Content { get; set; }

        public string Title { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
