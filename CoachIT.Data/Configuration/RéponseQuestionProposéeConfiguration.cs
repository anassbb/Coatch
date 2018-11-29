using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class RéponseQuestionProposéeConfiguration : EntityTypeConfiguration<RéponseQuestionProposée>
    {
        public RéponseQuestionProposéeConfiguration()
        {

            // primary key

            HasKey(t => t.RéponsePid);

            // Properties

            ToTable("RéponseQuestionProposée");

            Property(t => t.DateAjoutRp).IsRequired().HasColumnName("Date d'ajout");
            Property(t => t.ReponseP).IsRequired().HasMaxLength(200).HasColumnName("Réponse");
            Property(t => t.TypeRp).IsRequired().HasMaxLength(20).HasColumnName("Type Réponse");





        }
    }
}
