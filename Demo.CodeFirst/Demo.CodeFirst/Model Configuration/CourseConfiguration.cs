using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.CodeFirst.Model;

namespace Demo.CodeFirst.Model_Configuration
{
    class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(255);


            Property(c => c.Description)
            .IsRequired()
            .HasMaxLength(2000);


            HasRequired(c => c.Author)
            .WithMany(a => a.Courses)
            .HasForeignKey(c => c.AuthorId)
            .WillCascadeOnDelete(false);



            HasMany(c => c.Tags)
            .WithMany(t => t.Courses)
            .Map(m =>
            {
                m.ToTable("CourseTags");
                m.MapLeftKey("CourseId");
                m.MapRightKey("TagId");
            });



            HasRequired(c => c.Cover)
            .WithRequiredPrincipal(c => c.Course);
        }
    }
}
