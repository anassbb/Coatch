using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class TestProposéConfiguration : EntityTypeConfiguration<TestProposé>
    {
        public TestProposéConfiguration()
        {
            
            // properties

     //       ToTable("TestProposé");

            Property(t => t.DateLimite).IsRequired().HasColumnName("Date Limite");
            Property(t => t.Etat).IsRequired().HasColumnName("Etat");


            // Table & Column Mappings


            HasMany(a => a.QuestionProposées).WithRequired(a => a.TestProposé);

        }
    }
}


