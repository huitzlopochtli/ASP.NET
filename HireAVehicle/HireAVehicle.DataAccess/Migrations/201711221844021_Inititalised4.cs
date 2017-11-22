namespace HireAVehicle.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inititalised4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Admins", "AdminId");
            DropColumn("dbo.Drivers", "DriverId");
            DropColumn("dbo.Customers", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerId", c => c.String(nullable: false));
            AddColumn("dbo.Drivers", "DriverId", c => c.String(nullable: false));
            AddColumn("dbo.Admins", "AdminId", c => c.String(nullable: false));
        }
    }
}
