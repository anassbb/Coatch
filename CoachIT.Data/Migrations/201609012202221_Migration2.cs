namespace CoachIT.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Utilisateurs", name: "ID Question", newName: "ID User");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Utilisateurs", name: "ID User", newName: "ID Question");
        }
    }
}
