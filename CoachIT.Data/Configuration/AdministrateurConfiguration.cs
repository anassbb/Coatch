using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class AdministrateurConfiguration:EntityTypeConfiguration<Administrateur>
{

    public AdministrateurConfiguration()
    {
        
        // Properties

        Property(t => t.NomAdmin).IsRequired().HasMaxLength(30);
        Property(t => t.PrénomAdmin).IsRequired().HasMaxLength(30);
        Property(t => t.CinAdmin).HasColumnName("Cin Admin");
        



            // Table & Column Mappings

        HasMany(a => a.Categories).WithRequired(a => a.Admin).HasForeignKey(b => b.AdminId);
            
        }
}
}
