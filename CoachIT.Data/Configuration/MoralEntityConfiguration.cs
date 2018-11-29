using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class MoralEntityConfiguration : EntityTypeConfiguration<MoralUser>
    {

        public MoralEntityConfiguration()
        {

            // Properties

        //    ToTable("MoralEntity");

            Property(t => t.RaisonSocial).IsRequired().HasMaxLength(30).HasColumnName("Raison Social");
            Property(t => t.RegistreCommercial).IsRequired().HasColumnName("Registre Commercial"); 
            Property(t => t.DateCréation).HasColumnName("Date de Création"); 
            Property(t => t.Secteur).IsRequired().HasMaxLength(100).HasColumnName("Secteur"); 
            



            // Table & Column Mappings




        }
    }
}
