namespace HireAVehicle.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialisedAll3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drivers", "Status");
        }
    }
}
