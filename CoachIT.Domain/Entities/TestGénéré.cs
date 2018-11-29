using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class TestGénéré:Test
    {
        public TestGénéré()
        {
            this.Questions=new HashSet<Question>();
        }


        public String Niveau { get; set; }
        public int Coefficient { get; set; }
        


        #region Navigation Properties

        public virtual SousCatégorie SousCatégorie { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

        #endregion

    }
}
