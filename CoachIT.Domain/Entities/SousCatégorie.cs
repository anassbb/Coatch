using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class SousCatégorie 
    {
        public SousCatégorie()
        {
            this.TestGénérés =new HashSet<TestGénéré>();
        }

        public int SousCategorieId { get; set; }
        public String NomSousCategorie { get; set; }
        public DateTime DateCreationSc { get; set; }
        


        #region Navigation Properties

        public virtual Catégorie Catégorie { get; set; }
        public virtual ICollection<TestGénéré> TestGénérés { get; set; }


        #endregion

    }
}
