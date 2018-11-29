using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Data.Repositories.RepositoriesFolder
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        public QuestionRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }


        // Add other specific methods here


        public void UpdateQuestionDetached(Question e)
        {
            Question existing = this.DataContext.Questions.OfType<Question>().FirstOrDefault(x => x.QuestionId == e.QuestionId);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(e).State = EntityState.Modified;

        }

    }
    public interface IQuestionRepository : IRepository<Question>
    {
        void UpdateQuestionDetached(Question e);
    }
}