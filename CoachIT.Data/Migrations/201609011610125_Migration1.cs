namespace CoachIT.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catégorie",
                c => new
                    {
                        CategorieId = c.String(nullable: false, maxLength: 128),
                        Catégorie = c.String(nullable: false, maxLength: 30),
                        DatedeCréation = c.DateTime(name: "Date de Création", nullable: false),
                        Admin_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.CategorieId)
                .ForeignKey("dbo.Utilisateurs", t => t.Admin_UserId)
                .Index(t => t.Admin_UserId);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        IDQuestion = c.Int(name: "ID Question", nullable: false, identity: true),
                        login = c.String(nullable: false, maxLength: 30),
                        Motdepasse = c.String(name: "Mot de passe", nullable: false),
                        Email = c.String(),
                        Adresse = c.String(),
                        Téléphone = c.Int(nullable: false),
                        ActiverDésactiver = c.Boolean(name: "Activer/Désactiver ", nullable: false),
                        DateInscription = c.DateTime(name: "Date Inscription ", nullable: false),
                        DateLastActivity = c.DateTime(name: "Date Last Activity ", nullable: false),
                        DatedechangementdeMDP = c.DateTime(name: "Date de changement de MDP ", nullable: false),
                        NomAdmin = c.String(),
                        PrénomAdmin = c.String(),
                        CinAdmin = c.Int(),
                        NomCandidat = c.String(),
                        PrenomCandidat = c.String(),
                        CinCandidat = c.Int(),
                        Profession = c.String(),
                        Nationalité = c.String(),
                        Alias = c.String(),
                        RaisonSocial = c.String(),
                        DateCréation = c.DateTime(),
                        RegistreCommercial = c.Int(),
                        Secteur = c.String(),
                        UserType = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IDQuestion);
            
            CreateTable(
                "dbo.SousCatégorie",
                c => new
                    {
                        SousCategorieId = c.String(nullable: false, maxLength: 128),
                        SousCatégorie = c.String(name: "Sous Catégorie", nullable: false, maxLength: 30),
                        DatedeCréation = c.DateTime(name: "Date de Création", nullable: false),
                        Catégorie_CategorieId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SousCategorieId)
                .ForeignKey("dbo.Catégorie", t => t.Catégorie_CategorieId, cascadeDelete: true)
                .Index(t => t.Catégorie_CategorieId);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        TestId = c.Int(nullable: false, identity: true),
                        Datedeproposition = c.DateTime(name: "Date de proposition", nullable: false),
                        Durée = c.Int(nullable: false),
                        NbreQuestion = c.Int(name: "Nbre Question", nullable: false),
                        Type = c.Boolean(nullable: false),
                        Niveau = c.String(),
                        Coéfficient = c.Int(),
                        DateLimite = c.DateTime(name: "Date Limite"),
                        Etat = c.Boolean(),
                        SousCatégorie_SousCategorieId = c.String(maxLength: 128),
                        TestType = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TestId)
                .ForeignKey("dbo.SousCatégorie", t => t.SousCatégorie_SousCategorieId, cascadeDelete: true)
                .Index(t => t.SousCatégorie_SousCategorieId);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        EnoncéQuestion = c.String(name: "Enoncé Question", nullable: false, maxLength: 200),
                        DateInsertion = c.DateTime(name: "Date Insertion", nullable: false),
                        TestGénéré_TestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Tests", t => t.TestGénéré_TestId, cascadeDelete: true)
                .Index(t => t.TestGénéré_TestId);
            
            CreateTable(
                "dbo.Réponse",
                c => new
                    {
                        Réponseid = c.Int(nullable: false, identity: true),
                        Réponse = c.String(nullable: false, maxLength: 200),
                        Datedajout = c.DateTime(name: "Date d'ajout", nullable: false),
                        TypeRéponse = c.String(name: "Type Réponse", nullable: false, maxLength: 20),
                        Question_QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Réponseid)
                .ForeignKey("dbo.Question", t => t.Question_QuestionId, cascadeDelete: true)
                .Index(t => t.Question_QuestionId);
            
            CreateTable(
                "dbo.Classements",
                c => new
                    {
                        ClassementId = c.String(nullable: false, maxLength: 128),
                        DateMaj = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClassementId);
            
            CreateTable(
                "dbo.QuestionProposée",
                c => new
                    {
                        QuestionPropid = c.Int(nullable: false, identity: true),
                        EnoncéQuestion = c.String(name: "Enoncé Question", nullable: false, maxLength: 200),
                        DateInsertion = c.DateTime(name: "Date Insertion", nullable: false),
                        TestProposé_TestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionPropid)
                .ForeignKey("dbo.Tests", t => t.TestProposé_TestId, cascadeDelete: true)
                .Index(t => t.TestProposé_TestId);
            
            CreateTable(
                "dbo.RéponseQuestionProposée",
                c => new
                    {
                        RéponsePid = c.Int(nullable: false, identity: true),
                        Réponse = c.String(nullable: false, maxLength: 200),
                        Datedajout = c.DateTime(name: "Date d'ajout", nullable: false),
                        TypeRéponse = c.String(name: "Type Réponse", nullable: false, maxLength: 20),
                        QuestionProposé_QuestionPropid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RéponsePid)
                .ForeignKey("dbo.QuestionProposée", t => t.QuestionProposé_QuestionPropid, cascadeDelete: true)
                .Index(t => t.QuestionProposé_QuestionPropid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuestionProposée", "TestProposé_TestId", "dbo.Tests");
            DropForeignKey("dbo.RéponseQuestionProposée", "QuestionProposé_QuestionPropid", "dbo.QuestionProposée");
            DropForeignKey("dbo.SousCatégorie", "Catégorie_CategorieId", "dbo.Catégorie");
            DropForeignKey("dbo.Tests", "SousCatégorie_SousCategorieId", "dbo.SousCatégorie");
            DropForeignKey("dbo.Question", "TestGénéré_TestId", "dbo.Tests");
            DropForeignKey("dbo.Réponse", "Question_QuestionId", "dbo.Question");
            DropForeignKey("dbo.Catégorie", "Admin_UserId", "dbo.Utilisateurs");
            DropIndex("dbo.RéponseQuestionProposée", new[] { "QuestionProposé_QuestionPropid" });
            DropIndex("dbo.QuestionProposée", new[] { "TestProposé_TestId" });
            DropIndex("dbo.Réponse", new[] { "Question_QuestionId" });
            DropIndex("dbo.Question", new[] { "TestGénéré_TestId" });
            DropIndex("dbo.Tests", new[] { "SousCatégorie_SousCategorieId" });
            DropIndex("dbo.SousCatégorie", new[] { "Catégorie_CategorieId" });
            DropIndex("dbo.Catégorie", new[] { "Admin_UserId" });
            DropTable("dbo.RéponseQuestionProposée");
            DropTable("dbo.QuestionProposée");
            DropTable("dbo.Classements");
            DropTable("dbo.Réponse");
            DropTable("dbo.Question");
            DropTable("dbo.Tests");
            DropTable("dbo.SousCatégorie");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.Catégorie");
        }
    }
}
