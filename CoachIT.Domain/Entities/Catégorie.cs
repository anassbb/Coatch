using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class Catégorie
    {
        public Catégorie()
        {
            this.SousCatégories=new HashSet<SousCatégorie>();
        }


        public int CategorieId { get; set; }
        public String NomCategorie { get; set; }
        public DateTime DateCreationC  { get; set; }
        public int AdminId { get; set; }
        

        #region Navigation Properties

        public virtual Administrateur Admin { get; set; }

        public virtual ICollection<SousCatégorie>SousCatégories { get; set; }

        #endregion

    }
}
