using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class CandidatConfiguration : EntityTypeConfiguration<Candidat>
    {

        public CandidatConfiguration()
        {

            // Properties

         //   ToTable("Candidat");


            Property(t => t.NomCandidat).IsRequired().HasMaxLength(30).HasColumnName("Nom Candidat");
            Property(t => t.PrenomCandidat).IsRequired().HasMaxLength(30).HasColumnName("Prénom Admin");
            Property(t => t.CinCandidat).HasColumnName("Cin Candidat");
            Property(t => t.Profession).IsRequired().HasMaxLength(30).HasColumnName("Profession");  
            Property(t => t.Nationalité).IsRequired().HasMaxLength(30).HasColumnName("Nationalité");  
            Property(t => t.Alias).HasMaxLength(30).HasColumnName("Alias");  



            // Table & Column Mappings

           


        }
    }
}

