using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBP.Entity
{
    public class Blog
    {
        public int? Id { get; set; }
        public string Title { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }
        public string Content { get; set; }


        public User User { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public BlogCatagory BlogCatagory { get; set; }
        [ForeignKey("BlogCatagory")]
        public int BlogCatagoryId { get; set; }


        public BlogType BlogType { get; set; }
        [ForeignKey("BlogType")]
        public int BlogTypeId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsDeleted { get; set; }

        public bool  IsPublished { get; set; }

        public Blog()
        {
            Comments = new HashSet<Comment>();
        }
    }
}
