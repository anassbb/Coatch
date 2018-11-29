namespace CoachIT.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Catégorie", name: "Admin_UserId", newName: "AdminId");
            RenameIndex(table: "dbo.Catégorie", name: "IX_Admin_UserId", newName: "IX_AdminId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Catégorie", name: "IX_AdminId", newName: "IX_Admin_UserId");
            RenameColumn(table: "dbo.Catégorie", name: "AdminId", newName: "Admin_UserId");
        }
    }
}
