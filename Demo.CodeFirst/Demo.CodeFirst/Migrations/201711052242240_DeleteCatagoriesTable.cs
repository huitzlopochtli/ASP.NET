namespace Demo.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCatagoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo._Catagories",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("Insert into _Catagories(Name) Select Name From Catagories");

            DropTable("dbo.Catagories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("Insert into Catagories(Name) Select Name From _Catagories");

            DropTable("dbo._Catagories");

        }
    }
}
