using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class Candidat : User
    {
        public String NomCandidat { get; set; }
        public String PrenomCandidat { get; set; }
        public int CinCandidat { get; set; }
        public String Profession { get; set; }
        public String Nationalité { get; set; }
        public String Alias { get; set; }



        #region Navigation Properties
        #endregion

    }
}
