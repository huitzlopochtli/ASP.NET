namespace HireAVehicle.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        ContactNo = c.String(nullable: false),
                        RideStatus = c.Boolean(nullable: false),
                        TotalRides = c.Int(),
                        AccountType = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Official_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Officials", t => t.Official_Id)
                .Index(t => t.Official_Id);
            
            CreateTable(
                "dbo.Officials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdminId = c.String(),
                        ModeratorId = c.String(),
                        Salary = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DriverId = c.String(nullable: false),
                        DrivingLicence = c.String(nullable: false),
                        TotalEarnings = c.Single(nullable: false),
                        IsValidated = c.Boolean(nullable: false),
                        Account_Id = c.Int(),
                        ValidatedBy_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .ForeignKey("dbo.Officials", t => t.ValidatedBy_Id)
                .Index(t => t.Account_Id)
                .Index(t => t.ValidatedBy_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.String(nullable: false),
                        WalletBalance = c.Single(nullable: false),
                        RewordPoint = c.Single(nullable: false),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Single(nullable: false),
                        PaymentType_Id = c.Int(),
                        Ride_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentType_Id)
                .ForeignKey("dbo.Rides", t => t.Ride_Id)
                .Index(t => t.PaymentType_Id)
                .Index(t => t.Ride_Id);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentTypeId = c.String(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PickUpDateTime = c.DateTime(nullable: false),
                        PickUpLocation = c.String(nullable: false),
                        DropDateTime = c.DateTime(nullable: false),
                        DropLocation = c.String(nullable: false),
                        Amount = c.Single(nullable: false),
                        IsPayed = c.Boolean(nullable: false),
                        Customer_Id = c.Int(),
                        Driver_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Drivers", t => t.Driver_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.Driver_Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehicleId = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        RegistrationNumber = c.String(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        LicenceNumber = c.String(nullable: false),
                        BasePrice = c.Single(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Driver_Id = c.Int(),
                        VehicleType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.Driver_Id)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleType_Id)
                .Index(t => t.Driver_Id)
                .Index(t => t.VehicleType_Id);
            
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        ModelName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes");
            DropForeignKey("dbo.Vehicles", "Driver_Id", "dbo.Drivers");
            DropForeignKey("dbo.Payments", "Ride_Id", "dbo.Rides");
            DropForeignKey("dbo.Rides", "Driver_Id", "dbo.Drivers");
            DropForeignKey("dbo.Rides", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Payments", "PaymentType_Id", "dbo.PaymentTypes");
            DropForeignKey("dbo.Customers", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Officials", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Drivers", "ValidatedBy_Id", "dbo.Officials");
            DropForeignKey("dbo.Accounts", "Official_Id", "dbo.Officials");
            DropForeignKey("dbo.Drivers", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Vehicles", new[] { "VehicleType_Id" });
            DropIndex("dbo.Vehicles", new[] { "Driver_Id" });
            DropIndex("dbo.Rides", new[] { "Driver_Id" });
            DropIndex("dbo.Rides", new[] { "Customer_Id" });
            DropIndex("dbo.Payments", new[] { "Ride_Id" });
            DropIndex("dbo.Payments", new[] { "PaymentType_Id" });
            DropIndex("dbo.Customers", new[] { "Account_Id" });
            DropIndex("dbo.Drivers", new[] { "ValidatedBy_Id" });
            DropIndex("dbo.Drivers", new[] { "Account_Id" });
            DropIndex("dbo.Officials", new[] { "Account_Id" });
            DropIndex("dbo.Accounts", new[] { "Official_Id" });
            DropTable("dbo.VehicleTypes");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Rides");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Payments");
            DropTable("dbo.Customers");
            DropTable("dbo.Drivers");
            DropTable("dbo.Officials");
            DropTable("dbo.Accounts");
        }
    }
}
