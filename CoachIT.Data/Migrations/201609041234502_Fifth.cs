namespace CoachIT.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fifth : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Catégorie", name: "Catégorie ID", newName: "CategorieId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Catégorie", name: "CategorieId", newName: "Catégorie ID");
        }
    }
}
