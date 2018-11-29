using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Repositories.RepositoriesFolder
{
    public class RéponseQuestionProposéeRepository : RepositoryBase<RéponseQuestionProposée>, IRéponseQuestionProposéRepository
    {
        public RéponseQuestionProposéeRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }


        // Add other specific methods here

        public void UpdateRéponseQuestionProposéeDetached(RéponseQuestionProposée e)
        {
            RéponseQuestionProposée existing = this.DataContext.RéponseQuestionProposées.OfType<RéponseQuestionProposée>().FirstOrDefault(x => x.RéponsePid == e.RéponsePid);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(e).State = EntityState.Modified;

        }


    }
    public interface IRéponseQuestionProposéRepository : IRepository<RéponseQuestionProposée>
    {
        void UpdateRéponseQuestionProposéeDetached(RéponseQuestionProposée e);
    }
}