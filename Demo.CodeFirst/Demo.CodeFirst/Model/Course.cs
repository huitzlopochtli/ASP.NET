using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CodeFirst.Model
{
    class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [MaxLength(2000)]
        [MinLength(10)]
        public string Description { get; set; }

        public CourseLevel Level { get; set; }

        public float FullPrice { get; set; }

        public Author Author { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public IList<Tag> Tags { get; set; }

    }

    public enum CourseLevel
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }

}
