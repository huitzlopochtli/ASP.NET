namespace Demo.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCatagoryToCourses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Catagory_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Catagory_Id");
            AddForeignKey("dbo.Courses", "Catagory_Id", "dbo.Catagories", "Id");
            Sql("Update Courses SET Catagory_Id = 1");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Catagory_Id", "dbo.Catagories");
            DropIndex("dbo.Courses", new[] { "Catagory_Id" });
            DropColumn("dbo.Courses", "Catagory_Id");
        }
    }
}
