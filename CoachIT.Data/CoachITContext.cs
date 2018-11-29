using System.Data.Entity;
using CoachIT.Domain.Entities;
using CoachIT.Data.Configuration;

namespace CoachIT.Data
{
    public class CoachITContext: DbContext
    {
        public CoachITContext() : base("data source=.\\SQLEXPRESS;initial catalog=CoachITBase;integrated security=True")
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Administrateur> Administrateurs { get; set; }
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<MoralUser> MoralUsers { get; set; }
        public DbSet<Catégorie> Catégories { get; set; }
        public DbSet<SousCatégorie> SousCatégories { get; set; }
        public DbSet<Classement> Classements { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestGénéré> TestGénérés { get; set; }
        public DbSet<TestProposé> TestProposés { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionPoposée> QuestionPoposées { get; set; }
        public DbSet<Réponse> Réponses { get; set; }
        public DbSet<RéponseQuestionProposée> RéponseQuestionProposées { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new AdministrateurConfiguration());
            modelBuilder.Configurations.Add(new CandidatConfiguration());
            modelBuilder.Configurations.Add(new MoralEntityConfiguration());
            modelBuilder.Configurations.Add(new CategorieConfiguration());
            modelBuilder.Configurations.Add(new SousCategorieConfiguration());
            modelBuilder.Configurations.Add(new TestConfiguration());
            modelBuilder.Configurations.Add(new TestGénéréConfiguration());
            modelBuilder.Configurations.Add(new TestProposéConfiguration());
            modelBuilder.Configurations.Add(new QuestionConfiguration());
            modelBuilder.Configurations.Add(new QuestionProposéeConfiguration());
            modelBuilder.Configurations.Add(new RéponseConfiguration());
            modelBuilder.Configurations.Add(new RéponseQuestionProposéeConfiguration());

        }
    }

}


