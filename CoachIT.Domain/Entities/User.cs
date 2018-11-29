using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachIT.Domain.Entities
{
    public class User
    {
        public Int32 UserId { get; set; }

        public String Login { get; set; }

        public String Password { get; set; }

        public String Email { get; set; }

        public String Adress { get; set; }

        public int Phonenumber { get; set; }

        public Boolean Statu { get; set; }

        public DateTime InscriptionDate { get; set; }

        public DateTime LastActivityDate { get; set; }

        public DateTime LastPasswordChangeDate { get; set; }


        

    }
}
