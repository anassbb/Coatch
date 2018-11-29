using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class RéponseQuestionProposée
    {
        public int RéponsePid { get; set; }
        public String ReponseP { get; set; }
        public DateTime DateAjoutRp { get; set; }
        public String TypeRp { get; set; }


        #region Navigation Properties
        public virtual QuestionPoposée QuestionProposé { get; set; }

        #endregion
    }
}
