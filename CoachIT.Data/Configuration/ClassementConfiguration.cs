using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class ClassementConfiguration:EntityTypeConfiguration<Classement>
    {
        public ClassementConfiguration()
        {
            // Primary Key

            HasKey(t => t.ClassementId);

            //Properties

            ToTable("Classement");

            Property(t => t.DateMaj).IsRequired().HasColumnName("Date MAJ");


            // Table & Column Mappings

        }
    }
}
