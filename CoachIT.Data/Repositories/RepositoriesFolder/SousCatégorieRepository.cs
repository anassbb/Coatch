using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Repositories.RepositoriesFolder
{
   public class SousCategorieRepository : RepositoryBase<SousCatégorie>, ISousCategorieRepository
        {
            public SousCategorieRepository(DatabaseFactory dbFactory)
                : base(dbFactory)
            {
            }


        // Add other specific methods here

        public void UpdateSousCatégorieDetached(SousCatégorie e)
        {
            SousCatégorie existing = this.DataContext.SousCatégories.OfType<SousCatégorie>().FirstOrDefault(x => x.SousCategorieId == e.SousCategorieId);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(e).State = EntityState.Modified;

        }
    }
        public interface ISousCategorieRepository : IRepository<SousCatégorie>
        {
        void UpdateSousCatégorieDetached(SousCatégorie e);
    }
    }
