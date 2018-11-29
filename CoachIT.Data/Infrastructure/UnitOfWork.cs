using System;
using CoachIT.Data.Repositories.RepositoriesFolder;

namespace CoachIT.Data.Infrastructure
{
        public class UnitOfWork : IUnitOfWork
        {
            private CoachITContext dataContext;
            DatabaseFactory dbFactory;
            public UnitOfWork(DatabaseFactory dbFactory)
            {
                this.dbFactory = dbFactory;
            }
            private IUserRepository userRepository;
        IUserRepository IUnitOfWork.UserRepository
        {
                get { return userRepository ?? (userRepository = new UserRepository(dbFactory)); }
            }

        
        private ICategorieRepository categorieRepository;
        ICategorieRepository IUnitOfWork.CategorieRepository
        {
            get { return categorieRepository ?? (categorieRepository = new CategorieRepository(dbFactory)); }
        }


        private ISousCategorieRepository sousCategorieRepository;
        ISousCategorieRepository IUnitOfWork.SousCategorieRepository
        {
            get { return sousCategorieRepository ?? (sousCategorieRepository = new SousCategorieRepository(dbFactory)); }
        }

        private ITestRepository testRepository;
        ITestRepository IUnitOfWork.TestRepository
            {
                get { return testRepository ?? (testRepository = new TestRepository(dbFactory)); }
            }
        
        
        private IQuestionRepository questionRepository;
        IQuestionRepository IUnitOfWork.QuestionRepository
        {
            get { return questionRepository ?? (questionRepository = new QuestionRepository(dbFactory)); }
        }

        private IQuestionProposéRepository questionProposéeRepository;
        IQuestionProposéRepository IUnitOfWork.QuestionProposéeRepository
        {
            get { return questionProposéeRepository ?? (questionProposéeRepository = new QuestionProposéRepository(dbFactory)); }
        }


        private IRéponseRepository réponseRepository;
        IRéponseRepository IUnitOfWork.RéponseRepository
        {
            get { return réponseRepository ?? (réponseRepository = new RéponseRepository(dbFactory)); }
        }


        private IRéponseQuestionProposéRepository réponseQuestionProposéRepository;
        IRéponseQuestionProposéRepository IUnitOfWork.RéponseQuestionProposéeRepository
        {
            get { return réponseQuestionProposéRepository ?? (réponseQuestionProposéRepository = new RéponseQuestionProposéeRepository(dbFactory)); }
        }

            private IClassementRepository classementRepository;
        IClassementRepository IUnitOfWork.ClassementRepository
        {
            get { return classementRepository ?? (classementRepository = new ClassementRepository(dbFactory)); }
        }





        protected CoachITContext DataContext
        {
            get
            {
                return dataContext ?? (dataContext = dbFactory.Get());
            }
        }


        public void Commit()
        {
            DataContext.Commit();
        }
    }

    ////////    private IAdministrateurRepository administrateurRepository;
    ////////IAdministrateurRepository IUnitOfWork.AdministrateurRepository
    ////////    {
    ////////        get { return administrateurRepository ?? (administrateurRepository = new AdministrateurRepository(dbFactory)); }
    ////////    }

    ////////    private IMoralUserRepository moraluserRepository;
    ////////IMoralUserRepository IUnitOfWork.MoralUserRepository
    ////////    {
    ////////        get { return moraluserRepository ?? (moraluserRepository = new MoralUserRepository(dbFactory)); }
    ////////    }

    ////////    private ICandidatRepository candidatRepository;
    ////////ICandidatRepository IUnitOfWork.CandidatRepository
    ////////{
    ////////        get { return candidatRepository ?? (candidatRepository = new CandidatRepository(dbFactory)); }
    ////////    }



    ////////private ITestGénéréRepository testGénéréRepository;
    ////////ITestGénéréRepository IUnitOfWork.TestGénéréRepository
    ////////{
    ////////    get { return testGénéréRepository ?? (testGénéréRepository = new TestGénéréRepository(dbFactory)); }
    ////////}

    ////////private ITestProposéRepository testProposéRepository;
    ////////ITestProposéRepository IUnitOfWork.TestProposéRepository
    ////////{
    ////////    get { return testProposéRepository ?? (testProposéRepository = new TestProposéRepository(dbFactory)); }
    ////////}




}