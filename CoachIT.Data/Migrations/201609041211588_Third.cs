namespace CoachIT.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SousCatégorie", "Catégorie_CategorieId", "dbo.Catégorie");
            DropForeignKey("dbo.Tests", "SousCatégorie_SousCategorieId", "dbo.SousCatégorie");
            DropIndex("dbo.SousCatégorie", new[] { "Catégorie_CategorieId" });
            DropIndex("dbo.Tests", new[] { "SousCatégorie_SousCategorieId" });
            DropPrimaryKey("dbo.Catégorie");
            DropPrimaryKey("dbo.SousCatégorie");
            DropPrimaryKey("dbo.Classements");
            AlterColumn("dbo.Catégorie", "CategorieId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.SousCatégorie", "SousCategorieId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.SousCatégorie", "Catégorie_CategorieId", c => c.Int(nullable: false));
            AlterColumn("dbo.Tests", "SousCatégorie_SousCategorieId", c => c.Int());
            AlterColumn("dbo.Classements", "ClassementId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Catégorie", "CategorieId");
            AddPrimaryKey("dbo.SousCatégorie", "SousCategorieId");
            AddPrimaryKey("dbo.Classements", "ClassementId");
            CreateIndex("dbo.SousCatégorie", "Catégorie_CategorieId");
            CreateIndex("dbo.Tests", "SousCatégorie_SousCategorieId");
            AddForeignKey("dbo.SousCatégorie", "Catégorie_CategorieId", "dbo.Catégorie", "CategorieId", cascadeDelete: true);
            AddForeignKey("dbo.Tests", "SousCatégorie_SousCategorieId", "dbo.SousCatégorie", "SousCategorieId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tests", "SousCatégorie_SousCategorieId", "dbo.SousCatégorie");
            DropForeignKey("dbo.SousCatégorie", "Catégorie_CategorieId", "dbo.Catégorie");
            DropIndex("dbo.Tests", new[] { "SousCatégorie_SousCategorieId" });
            DropIndex("dbo.SousCatégorie", new[] { "Catégorie_CategorieId" });
            DropPrimaryKey("dbo.Classements");
            DropPrimaryKey("dbo.SousCatégorie");
            DropPrimaryKey("dbo.Catégorie");
            AlterColumn("dbo.Classements", "ClassementId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Tests", "SousCatégorie_SousCategorieId", c => c.String(maxLength: 128));
            AlterColumn("dbo.SousCatégorie", "Catégorie_CategorieId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SousCatégorie", "SousCategorieId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Catégorie", "CategorieId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Classements", "ClassementId");
            AddPrimaryKey("dbo.SousCatégorie", "SousCategorieId");
            AddPrimaryKey("dbo.Catégorie", "CategorieId");
            CreateIndex("dbo.Tests", "SousCatégorie_SousCategorieId");
            CreateIndex("dbo.SousCatégorie", "Catégorie_CategorieId");
            AddForeignKey("dbo.Tests", "SousCatégorie_SousCategorieId", "dbo.SousCatégorie", "SousCategorieId", cascadeDelete: true);
            AddForeignKey("dbo.SousCatégorie", "Catégorie_CategorieId", "dbo.Catégorie", "CategorieId", cascadeDelete: true);
        }
    }
}
