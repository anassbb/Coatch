using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class MoralUser:User
    {

        public String RaisonSocial { get; set; }
        public DateTime DateCréation { get; set; }
        public int RegistreCommercial { get; set; }
        public String Secteur { get; set; }

        #region Navigation Properties
        #endregion
    }
}
