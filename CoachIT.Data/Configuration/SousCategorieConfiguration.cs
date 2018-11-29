using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class SousCategorieConfiguration : EntityTypeConfiguration<SousCatégorie>
    {

        public SousCategorieConfiguration()
        {

            // Primal Key
            HasKey(t => t.SousCategorieId);


            // Properties

            ToTable("SousCatégorie");

            Property(t => t.NomSousCategorie).IsRequired().HasMaxLength(30).HasColumnName("Sous Catégorie");
            Property(t => t.DateCreationSc).IsRequired().HasColumnName("Date de Création"); ;




            // Table & Column Mappings


            HasMany(a => a.TestGénérés).WithRequired(b => b.SousCatégorie);






        }
    }
}
