namespace Demo.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFluentAPI : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.Authors");
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
            AddForeignKey("dbo.Courses", "AuthorId", "dbo.Authors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.Authors");
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 60));
            AddForeignKey("dbo.Courses", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
    }
}
