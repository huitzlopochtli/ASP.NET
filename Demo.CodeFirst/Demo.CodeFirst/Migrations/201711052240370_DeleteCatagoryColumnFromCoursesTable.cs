namespace Demo.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCatagoryColumnFromCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Catagory_Id", "dbo.Catagories");
            DropIndex("dbo.Courses", new[] { "Catagory_Id" });
            DropColumn("dbo.Courses", "Catagory_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Catagory_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Catagory_Id");
            AddForeignKey("dbo.Courses", "Catagory_Id", "dbo.Catagories", "Id");
        }
    }
}
