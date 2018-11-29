using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Repositories.RepositoriesFolder
{
    public class RéponseRepository : RepositoryBase<Réponse>, IRéponseRepository
    {
        public RéponseRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }


        // Add other specific methods here

        public void UpdateRéponseDetached(Réponse e)
        {
            Réponse existing = this.DataContext.Réponses.OfType<Réponse>().FirstOrDefault(x => x.Réponseid == e.Réponseid);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(e).State = EntityState.Modified;

        }


    }
    public interface IRéponseRepository : IRepository<Réponse>
    {
        void UpdateRéponseDetached(Réponse e);
    }
}