using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class Réponse
    {
        public int Réponseid { get; set; }
        public String Reponse { get; set; }
        public DateTime DateAjoutR { get; set; }
        public String TypeR { get; set; }

        #region Navigation Properties

        public virtual Question Question { get; set; }

        #endregion


    }
}
