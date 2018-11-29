using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;
using System.Linq;

namespace CoachIT.Data.Repositories.RepositoriesFolder
{
    public class QuestionProposéRepository : RepositoryBase<QuestionPoposée>, IQuestionProposéRepository
    {
        public QuestionProposéRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }


        // Add other specific methods here

        public void UpdateQuestionPoposéeDetached(QuestionPoposée e)
        {
            QuestionPoposée existing = this.DataContext.QuestionPoposées.OfType<QuestionPoposée>().FirstOrDefault(x => x.QuestionPropid == e.QuestionPropid);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(e).State = EntityState.Modified;

        }


    }
    public interface IQuestionProposéRepository : IRepository<QuestionPoposée>
    {
        void UpdateQuestionPoposéeDetached(QuestionPoposée e);
    }
}