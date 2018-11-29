using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class Question
    {
        public Question()
        {
            this.Réponses=new List<Réponse>();
        }

        public int QuestionId { get; set; }
        public String EnoncéQ { get; set; }
        public DateTime DateInsertionQ { get; set; }


        #region Navigation Properties

        public virtual TestGénéré TestGénéré { get; set; }
        public virtual ICollection<Réponse> Réponses { get; set; }

        #endregion

    }
}
