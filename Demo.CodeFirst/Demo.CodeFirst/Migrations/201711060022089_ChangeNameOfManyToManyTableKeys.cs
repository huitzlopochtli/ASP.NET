namespace Demo.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameOfManyToManyTableKeys : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CourseTags", name: "Course_Id", newName: "CourseId");
            RenameColumn(table: "dbo.CourseTags", name: "Tag_Id", newName: "TagId");
            RenameIndex(table: "dbo.CourseTags", name: "IX_Course_Id", newName: "IX_CourseId");
            RenameIndex(table: "dbo.CourseTags", name: "IX_Tag_Id", newName: "IX_TagId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.CourseTags", name: "IX_TagId", newName: "IX_Tag_Id");
            RenameIndex(table: "dbo.CourseTags", name: "IX_CourseId", newName: "IX_Course_Id");
            RenameColumn(table: "dbo.CourseTags", name: "TagId", newName: "Tag_Id");
            RenameColumn(table: "dbo.CourseTags", name: "CourseId", newName: "Course_Id");
        }
    }
}
