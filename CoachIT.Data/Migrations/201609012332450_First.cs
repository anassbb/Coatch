namespace CoachIT.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Catégorie", "Admin_UserId", "dbo.Utilisateurs");
            DropIndex("dbo.Catégorie", new[] { "Admin_UserId" });
            RenameColumn(table: "dbo.Utilisateurs", name: "CinAdmin", newName: "Cin Admin");
            RenameColumn(table: "dbo.Utilisateurs", name: "NomCandidat", newName: "Nom Candidat");
            RenameColumn(table: "dbo.Utilisateurs", name: "PrenomCandidat", newName: "Prénom Admin");
            RenameColumn(table: "dbo.Utilisateurs", name: "CinCandidat", newName: "Cin Candidat");
            RenameColumn(table: "dbo.Utilisateurs", name: "RaisonSocial", newName: "Raison Social");
            RenameColumn(table: "dbo.Utilisateurs", name: "DateCréation", newName: "Date de Création");
            RenameColumn(table: "dbo.Utilisateurs", name: "RegistreCommercial", newName: "Registre Commercial");
            AlterColumn("dbo.Catégorie", "Admin_UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Utilisateurs", "NomAdmin", c => c.String(maxLength: 30));
            AlterColumn("dbo.Utilisateurs", "PrénomAdmin", c => c.String(maxLength: 30));
            AlterColumn("dbo.Utilisateurs", "Nom Candidat", c => c.String(maxLength: 30));
            AlterColumn("dbo.Utilisateurs", "Prénom Admin", c => c.String(maxLength: 30));
            AlterColumn("dbo.Utilisateurs", "Profession", c => c.String(maxLength: 30));
            AlterColumn("dbo.Utilisateurs", "Nationalité", c => c.String(maxLength: 30));
            AlterColumn("dbo.Utilisateurs", "Alias", c => c.String(maxLength: 30));
            AlterColumn("dbo.Utilisateurs", "Raison Social", c => c.String(maxLength: 30));
            AlterColumn("dbo.Utilisateurs", "Secteur", c => c.String(maxLength: 100));
            CreateIndex("dbo.Catégorie", "Admin_UserId");
            AddForeignKey("dbo.Catégorie", "Admin_UserId", "dbo.Utilisateurs", "ID User", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Catégorie", "Admin_UserId", "dbo.Utilisateurs");
            DropIndex("dbo.Catégorie", new[] { "Admin_UserId" });
            AlterColumn("dbo.Utilisateurs", "Secteur", c => c.String());
            AlterColumn("dbo.Utilisateurs", "Raison Social", c => c.String());
            AlterColumn("dbo.Utilisateurs", "Alias", c => c.String());
            AlterColumn("dbo.Utilisateurs", "Nationalité", c => c.String());
            AlterColumn("dbo.Utilisateurs", "Profession", c => c.String());
            AlterColumn("dbo.Utilisateurs", "Prénom Admin", c => c.String());
            AlterColumn("dbo.Utilisateurs", "Nom Candidat", c => c.String());
            AlterColumn("dbo.Utilisateurs", "PrénomAdmin", c => c.String());
            AlterColumn("dbo.Utilisateurs", "NomAdmin", c => c.String());
            AlterColumn("dbo.Catégorie", "Admin_UserId", c => c.Int());
            RenameColumn(table: "dbo.Utilisateurs", name: "Registre Commercial", newName: "RegistreCommercial");
            RenameColumn(table: "dbo.Utilisateurs", name: "Date de Création", newName: "DateCréation");
            RenameColumn(table: "dbo.Utilisateurs", name: "Raison Social", newName: "RaisonSocial");
            RenameColumn(table: "dbo.Utilisateurs", name: "Cin Candidat", newName: "CinCandidat");
            RenameColumn(table: "dbo.Utilisateurs", name: "Prénom Admin", newName: "PrenomCandidat");
            RenameColumn(table: "dbo.Utilisateurs", name: "Nom Candidat", newName: "NomCandidat");
            RenameColumn(table: "dbo.Utilisateurs", name: "Cin Admin", newName: "CinAdmin");
            CreateIndex("dbo.Catégorie", "Admin_UserId");
            AddForeignKey("dbo.Catégorie", "Admin_UserId", "dbo.Utilisateurs", "ID User");
        }
    }
}
