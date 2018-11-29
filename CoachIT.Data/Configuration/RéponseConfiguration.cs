using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class RéponseConfiguration:EntityTypeConfiguration<Réponse>
    {
        public RéponseConfiguration()
        {
               
            // primary key

            HasKey(t => t.Réponseid);

            // Properties

            ToTable("Réponse");

            Property(t => t.DateAjoutR).IsRequired().HasColumnName("Date d'ajout");
            Property(t => t.Reponse).IsRequired().HasMaxLength(200).HasColumnName("Réponse");
            Property(t => t.TypeR).IsRequired().HasMaxLength(20).HasColumnName("Type Réponse");





        }
    }
}
