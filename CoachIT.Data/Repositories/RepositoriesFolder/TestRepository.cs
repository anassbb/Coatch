using System.Data.Entity;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace CoachIT.Data.Repositories.RepositoriesFolder
{
    public class TestRepository : RepositoryBase<Test>, ITestRepository
    {
        public TestRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }


        // Add other specific methods here

        public void UpdateTestGénéréDetached(TestGénéré g)
        {
            TestGénéré existing = this.DataContext.TestGénérés.OfType<TestGénéré>().FirstOrDefault(x => x.TestId == g.TestId);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(g).State = EntityState.Modified;

        }

        

        public void UpdateTestProposéDetached(TestProposé p)
        {
            TestProposé existing = this.DataContext.TestProposés.OfType<TestProposé>().FirstOrDefault(x => x.TestId == p.TestId);

            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);

            this.DataContext.Entry(p).State = EntityState.Modified;

        }

        // Add other specific methods here

    }
    public interface ITestRepository : IRepository<Test>
    {
        void UpdateTestProposéDetached(TestProposé p);
        void UpdateTestGénéréDetached(TestGénéré g);

    }
}