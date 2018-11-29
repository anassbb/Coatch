using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class TestConfiguration:EntityTypeConfiguration<Test>
    {
        public TestConfiguration()
        {
            // primary Key

            HasKey(t => t.TestId);

            // properties

            ToTable("Tests");

            Property(t=>t.DateProposition).IsRequired().HasColumnName("Date de proposition");
            Property(t => t.Durée).IsRequired().HasColumnName("Durée");
            Property(t => t.NbreQuestion).IsRequired().HasColumnName("Nbre Question");
            Property(t=>t.Type).IsRequired().HasColumnName("Type");


            // TPH Inheritance 

            Map<TestProposé>(c =>
            {
                c.Requires("TestType").HasValue("TestProposé");
            })
                .Map<TestGénéré>(c =>
                {
                    c.Requires("TestType").HasValue("TestGénéré");
                });

        }
    }
}
