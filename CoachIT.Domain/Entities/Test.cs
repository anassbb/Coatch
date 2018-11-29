using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class Test
    {

        public int TestId { get; set; }
        public DateTime DateProposition { get; set; }
        public int Durée { get; set; }
        public int NbreQuestion { get; set; }
        public Boolean Type { get; set; }  // blanc ou pas


        #region Navigation Properties
        #endregion

    }
}
