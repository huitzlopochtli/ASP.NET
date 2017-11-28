namespace MVP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialised31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogCatagories", "Url", c => c.String());
            AddColumn("dbo.Blogs", "Url", c => c.String());
            AddColumn("dbo.Blogs", "IsPublished", c => c.Boolean(nullable: false));
            AddColumn("dbo.BlogTypes", "Url", c => c.String());
            AddColumn("dbo.Comments", "Url", c => c.String());
            AddColumn("dbo.Users", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Url");
            DropColumn("dbo.Comments", "Url");
            DropColumn("dbo.BlogTypes", "Url");
            DropColumn("dbo.Blogs", "IsPublished");
            DropColumn("dbo.Blogs", "Url");
            DropColumn("dbo.BlogCatagories", "Url");
        }
    }
}
