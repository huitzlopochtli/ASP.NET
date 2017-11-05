namespace Demo.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCatagories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);


            Sql("Insert into catagories (Name) values ('Web Development')");
            Sql("Insert into catagories (Name) values ('Programming Languages')");

        }
        
        public override void Down()
        {
            DropTable("dbo.Catagories");
        }
    }
}
