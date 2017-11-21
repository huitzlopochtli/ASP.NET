namespace HireAVehicle.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialisedAll2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PromoCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PromoCodeString = c.String(nullable: false),
                        MaxNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PromoCodes");
        }
    }
}
