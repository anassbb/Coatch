using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Configuration
{
    class QuestionConfiguration:EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {

            // Primary Key

            HasKey(t => t.QuestionId);

            // Properties

            ToTable("Question");

            Property(t => t.DateInsertionQ).IsRequired().HasColumnName("Date Insertion");
            Property(t => t.EnoncéQ).IsRequired().HasColumnName("Enoncé Question").HasMaxLength(200);


            // Table & Column Mappings


            HasMany(a => a.Réponses).WithRequired(b => b.Question).WillCascadeOnDelete(true);

        }
    }
}
