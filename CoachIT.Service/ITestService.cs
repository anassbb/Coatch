using System;
using System.Collections.Generic;
using System.Linq;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Service
{
    public interface ITestService
    {
        IEnumerable<Test> GetTests();
        IEnumerable<TestGénéré> GetTestGénérés();
        IEnumerable<TestProposé> GetTestProposés();

        Test GetTest(int id);
        TestGénéré GeTestGénéré(int id);
        TestProposé GeTestProposé(int id);
        
        void CreateTestGénéré(TestGénéré testGénéré);
        void CreateTestProposé(TestProposé testProposé);
       
        void UpdateTestGénéréDetached(TestGénéré e);
        void UpdateTestProposéDetached(TestProposé e);

        void DeleteTest(int id);
        void SaveTest();
        
        
    }

    public class TestService : ITestService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public TestService()
        {

        }

        #region ITestService Members



        IEnumerable<Test> ITestService.GetTests()
        {
            var tests = utOfWork.TestRepository.GetAll();
            return tests;
        }

        IEnumerable<TestGénéré> ITestService.GetTestGénérés()
        {
            var testGénérés = utOfWork.TestRepository.GetAll().OfType<TestGénéré>();
            return testGénérés;
        }

        IEnumerable<TestProposé> ITestService.GetTestProposés()
        {
            var testProposés = utOfWork.TestRepository.GetAll().OfType<TestProposé>();
            return testProposés;
        }
        
        
        Test ITestService.GetTest(int id)
        {
            var test = utOfWork.TestRepository.GetById(id);
            return test;
        }

        TestGénéré ITestService.GeTestGénéré(int id)
        {
            var testgénéré = utOfWork.TestRepository.GetById(id) as TestGénéré;
            return testgénéré;
        }

        TestProposé ITestService.GeTestProposé(int id)
        {
            var testproposé = utOfWork.TestRepository.GetById(id) as TestProposé;
            return testproposé;
        }

       
        void ITestService.CreateTestGénéré(TestGénéré testGénéré)
        {
            utOfWork.TestRepository.Add(testGénéré);

        }

        void ITestService.CreateTestProposé(TestProposé testProposé)
        {
            utOfWork.TestRepository.Add(testProposé);

        }

      
        void ITestService.UpdateTestProposéDetached(TestProposé c)
        {
            utOfWork.TestRepository.UpdateTestProposéDetached(c);
        }


        void ITestService.UpdateTestGénéréDetached(TestGénéré c)
        {
            utOfWork.TestRepository.UpdateTestGénéréDetached(c);
        }

        void ITestService.DeleteTest(int id)
        {
            var test = utOfWork.TestRepository.GetById(id);
            utOfWork.TestRepository.Delete(test);

        }

        void ITestService.SaveTest()
        {
            utOfWork.Commit();
        }

        #endregion
        
    }
}