using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class QuestionPoposée
    {
        public int QuestionPropid { get; set; }
        public String EnoncéQp { get; set; }
        public DateTime DateInsertionQp { get; set; }


        #region Navigation Properties

        public virtual TestProposé TestProposé { get; set; }
        public virtual ICollection<RéponseQuestionProposée> RéponseQuestionProposée { get; set; }

        #endregion

    }
}
