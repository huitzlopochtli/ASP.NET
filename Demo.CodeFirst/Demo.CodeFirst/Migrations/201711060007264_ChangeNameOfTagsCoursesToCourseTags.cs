namespace Demo.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameOfTagsCoursesToCourseTags : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TagCourses", newName: "CourseTags");
            DropPrimaryKey("dbo.CourseTags");
            AddPrimaryKey("dbo.CourseTags", new[] { "Course_Id", "Tag_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CourseTags");
            AddPrimaryKey("dbo.CourseTags", new[] { "Tag_Id", "Course_Id" });
            RenameTable(name: "dbo.CourseTags", newName: "TagCourses");
        }
    }
}
