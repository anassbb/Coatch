using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoachIT.Domain.Entities
{
    public class Users
    {
        public List<CoachIT.Domain.Entities.Candidat> ObtenirListeUsers(CoachIT.Domain.Entities.Candidat candidat)

        {

            return new List<CoachIT.Domain.Entities.Candidat>

        {

            candidat

        };

        }
        public List<CoachIT.Domain.Entities.MoralUser> ObtenirListeUsersMoral(CoachIT.Domain.Entities.MoralUser moralUser)

        {

            return new List<CoachIT.Domain.Entities.MoralUser>

        {

            moralUser

        };

        }
    }
}