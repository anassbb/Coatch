using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Repositories.RepositoriesFolder
{
    

    public class CategorieRepository : RepositoryBase<Catégorie>, ICategorieRepository
    {
        public CategorieRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }


        // Add other specific methods here

        public void UpdateCatégorieDetached(Catégorie e)
        {
            Catégorie existing = this.DataContext.Catégories.OfType<Catégorie>().FirstOrDefault(x => x.CategorieId == e.CategorieId);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(e).State = EntityState.Modified;

        }

    }

    public interface ICategorieRepository: IRepository<Catégorie>
    {
        void UpdateCatégorieDetached(Catégorie e);
    }
}