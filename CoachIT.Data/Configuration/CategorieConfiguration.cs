using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class CategorieConfiguration : EntityTypeConfiguration<Catégorie>
    {

        public CategorieConfiguration()
        {

            // Primal Key
            HasKey(t => t.CategorieId);


            // Properties

            ToTable("Catégorie");

            
            Property(t => t.NomCategorie).IsRequired().HasMaxLength(30).HasColumnName("Catégorie");
            Property(t => t.DateCreationC).IsRequired().HasColumnName("Date de Création"); 




            // Table & Column Mappings


            HasMany(a => a.SousCatégories).WithRequired(b => b.Catégorie);


        }
    }
}

