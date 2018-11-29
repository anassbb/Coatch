using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class TestGénéréConfiguration : EntityTypeConfiguration<TestGénéré>
    {
        public TestGénéréConfiguration()
        {

            // properties

        //    ToTable("TestGénéré");

            Property(t => t.Coefficient).IsRequired().HasColumnName("Coéfficient");
            Property(t => t.Niveau).IsRequired().HasColumnName("Niveau");


            // Table & Column Mappings


            HasMany(a => a.Questions).WithRequired(a => a.TestGénéré);

        }
    }
}
