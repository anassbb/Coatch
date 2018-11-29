using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class Administrateur:User
    {

        public Administrateur()
        {
                this.Categories=new HashSet<Catégorie>();
        }

        public String NomAdmin { get; set; }
        public String PrénomAdmin { get; set; }
        public int CinAdmin { get; set; }

        #region Navigation Properties

        public virtual ICollection<Catégorie> Categories { get; set; }

        #endregion

    }
}
