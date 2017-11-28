namespace MVP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialised32 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Logins", name: "Role_Id", newName: "RoleId");
            RenameIndex(table: "dbo.Logins", name: "IX_Role_Id", newName: "IX_RoleId");
            AddColumn("dbo.Logins", "IsVarified", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Logins", "IsVarified");
            RenameIndex(table: "dbo.Logins", name: "IX_RoleId", newName: "IX_Role_Id");
            RenameColumn(table: "dbo.Logins", name: "RoleId", newName: "Role_Id");
        }
    }
}
