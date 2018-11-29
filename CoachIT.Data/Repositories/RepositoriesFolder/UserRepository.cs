using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;
using System;

namespace CoachIT.Data.Repositories.RepositoriesFolder
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
            public UserRepository(DatabaseFactory dbFactory)
                : base(dbFactory)
            {
            }


        // Add other specific methods here


        public void UpdateAdministrateurDetached(Administrateur a)
        {
            Administrateur existing = this.DataContext.Users.OfType<Administrateur>().FirstOrDefault(x => x.UserId == a.UserId);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(a).State = EntityState.Modified;

        }

        public void UpdateMoralUserDetached(MoralUser m)
        {
            MoralUser existing = this.DataContext.Users.OfType<MoralUser>().FirstOrDefault(x => x.UserId == m.UserId);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(m).State = EntityState.Modified;

        }

        public void UpdateCandidatDetached(Candidat c)
        {
            Candidat existing = this.DataContext.Users.OfType<Candidat>().FirstOrDefault(x => x.UserId == c.UserId);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(c).State = EntityState.Modified;

        }

        public int GetByLogin(User usr)
        {
            User existing = this.DataContext.Users.OfType<User>().FirstOrDefault(x => x.Login == usr.Login);
            if (existing != null)
            {
                return existing.UserId;
            }
            else
            {
                return 0;
            }
      
        }


    }
    public interface IUserRepository : IRepository<User>
        {
        void UpdateAdministrateurDetached(Administrateur a);
        void UpdateCandidatDetached(Candidat c);
        void UpdateMoralUserDetached(MoralUser m);
        int GetByLogin(User usr);
        }

    }
