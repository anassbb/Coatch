using System;
using System.Collections.Generic;
using System.Linq;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Service
{
    public interface IQuestionService
    {
        IEnumerable<Question> GetQuestions();
        Question GetQuestion(int id);
        void CreateQuestion(Question question);
        void DeleteQuestion(int id);
        void SaveQuestion();
        void UpdateQuestion(Question question);
        void UpdateQuestionDetached(Question question);
    }

    public class QuestionService : IQuestionService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public QuestionService()
        {

        }

        void IQuestionService.CreateQuestion(Question question)
        {
            utOfWork.QuestionRepository.Add(question);
        }

        void IQuestionService.DeleteQuestion(int id)
        {
            var question = utOfWork.QuestionRepository.GetById(id);
            utOfWork.QuestionRepository.Delete(question);
        }

        Question IQuestionService.GetQuestion(int id)
        {
            var question = utOfWork.QuestionRepository.GetById(id);
            return question;
        }

        IEnumerable<Question> IQuestionService.GetQuestions()
        {
            var questions = utOfWork.QuestionRepository.GetAll();
            return questions;
        }

        void IQuestionService.SaveQuestion()
        {
            utOfWork.Commit();
        }

        void IQuestionService.UpdateQuestion(Question question)
        {
            utOfWork.QuestionRepository.Update(question);
        }

        void IQuestionService.UpdateQuestionDetached(Question question)
        {
            utOfWork.QuestionRepository.UpdateQuestionDetached(question);
        }
    }
}