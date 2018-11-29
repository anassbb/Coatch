using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class TestProposé:Test
    {

        public TestProposé()
        {
            this.QuestionProposées=new HashSet<QuestionPoposée>();
        }

        public DateTime DateLimite { get; set; }
        public Boolean Etat { get; set; }



        #region Navigation Properties

        public virtual ICollection<QuestionPoposée> QuestionProposées { get; set; }

        #endregion

    }
}
