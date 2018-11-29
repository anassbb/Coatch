using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;


namespace CoachIT.Data.Configuration
{
    class QuestionProposéeConfiguration : EntityTypeConfiguration<QuestionPoposée>
    {
        public QuestionProposéeConfiguration()
        {

            // Primary Key

            HasKey(t => t.QuestionPropid);

            // Properties

            ToTable("QuestionProposée");

            Property(t => t.DateInsertionQp).IsRequired().HasColumnName("Date Insertion");
            Property(t => t.EnoncéQp).IsRequired().HasColumnName("Enoncé Question").HasMaxLength(200);

            // Table & Column Mappings


            HasMany(a => a.RéponseQuestionProposée).WithRequired(b => b.QuestionProposé);

        }
    }
}
