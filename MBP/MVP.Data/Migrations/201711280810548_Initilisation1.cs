namespace MVP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initilisation1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogCatagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Content = c.String(),
                        Title = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Content = c.String(),
                        UserId = c.Int(nullable: false),
                        BlogCatagoryId = c.Int(nullable: false),
                        BlogTypeId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BlogCatagories", t => t.BlogCatagoryId, cascadeDelete: true)
                .ForeignKey("dbo.BlogTypes", t => t.BlogTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.BlogCatagoryId)
                .Index(t => t.BlogTypeId);
            
            CreateTable(
                "dbo.BlogTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BlogId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        CommentParent = c.Int(),
                        Content = c.String(),
                        Title = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.BlogId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fullname = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        LoginId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Logins", t => t.LoginId, cascadeDelete: true)
                .Index(t => t.LoginId);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role_Id = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        LastLOgin = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        RoleDesctription = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        Name = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Permissions", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Blogs", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "LoginId", "dbo.Logins");
            DropForeignKey("dbo.Logins", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Comments", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.Blogs", "BlogTypeId", "dbo.BlogTypes");
            DropForeignKey("dbo.Blogs", "BlogCatagoryId", "dbo.BlogCatagories");
            DropIndex("dbo.Permissions", new[] { "RoleId" });
            DropIndex("dbo.Logins", new[] { "Role_Id" });
            DropIndex("dbo.Users", new[] { "LoginId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.Comments", new[] { "BlogId" });
            DropIndex("dbo.Blogs", new[] { "BlogTypeId" });
            DropIndex("dbo.Blogs", new[] { "BlogCatagoryId" });
            DropIndex("dbo.Blogs", new[] { "UserId" });
            DropTable("dbo.Permissions");
            DropTable("dbo.Roles");
            DropTable("dbo.Logins");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.BlogTypes");
            DropTable("dbo.Blogs");
            DropTable("dbo.BlogCatagories");
        }
    }
}
