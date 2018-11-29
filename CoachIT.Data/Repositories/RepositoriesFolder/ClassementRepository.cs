using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Repositories.RepositoriesFolder
{
 
        public class ClassementRepository : RepositoryBase<Classement>, IClassementRepository
    {
            public ClassementRepository(DatabaseFactory dbFactory)
                : base(dbFactory)
            {
            }


            // Add other specific methods here

            public void UpdateClassementDetached(Classement e)
            {
            Classement existing = this.DataContext.Classements.OfType<Classement>().FirstOrDefault(x => x.ClassementId == e.ClassementId);

                ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

                this.DataContext.Entry(e).State = EntityState.Modified;

            }


        }
        public interface IClassementRepository : IRepository<Classement>
        {

        void UpdateClassementDetached(Classement e);
    }
    }
