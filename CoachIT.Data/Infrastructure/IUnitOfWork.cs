using CoachIT.Data.Repositories.RepositoriesFolder;

namespace CoachIT.Data.Infrastructure
{
    public interface IUnitOfWork
    {
            void Commit();
            IUserRepository UserRepository { get; }
            ICategorieRepository CategorieRepository { get; }            
            ISousCategorieRepository SousCategorieRepository { get; }
            ITestRepository TestRepository { get; }
            IClassementRepository ClassementRepository { get; }
           
            IQuestionRepository QuestionRepository { get; }
            IQuestionProposéRepository QuestionProposéeRepository { get; }
            IRéponseRepository RéponseRepository { get; }
            IRéponseQuestionProposéRepository RéponseQuestionProposéeRepository { get; }


        //////IAdministrateurRepository AdministrateurRepository { get; }
        //////ICandidatRepository CandidatRepository { get; }
        //////IMoralUserRepository MoralUserRepository { get; }    
        //////ITestGénéréRepository TestGénéréRepository { get; }
        //////ITestProposéRepository TestProposéRepository { get; }



    }
}