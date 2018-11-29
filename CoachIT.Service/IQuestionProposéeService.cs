using System.Collections.Generic;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Service
{
    public interface IQuestionProposéeService
    {
        
            IEnumerable<QuestionPoposée> GetQuestionsProposées();
            QuestionPoposée GetQuestionProposée(int id);
            void CreateQuestionProposée(QuestionPoposée questionProposée);
            void DeleteQuestionProposée(int id);
            void SaveQuestionProposée();
            void UpdateQuestionProposée(QuestionPoposée questionProposée);
            void UpdateQuestionProposéeDetached(QuestionPoposée questionProposée);
        }

        public class QuestionProposéeService : IQuestionProposéeService
    {
            static DatabaseFactory dbFactory = new DatabaseFactory();
            IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

            public QuestionProposéeService()
            {

            }

            void IQuestionProposéeService.CreateQuestionProposée(QuestionPoposée questionProposé)
            {
                utOfWork.QuestionProposéeRepository.Add(questionProposé);
            }

            void IQuestionProposéeService.DeleteQuestionProposée(int id)
            {
                var questionproposéé = utOfWork.QuestionProposéeRepository.GetById(id);
                utOfWork.QuestionProposéeRepository.Delete(questionproposéé);
            }

            QuestionPoposée IQuestionProposéeService.GetQuestionProposée(int id)
            {
                var questionProposé = utOfWork.QuestionProposéeRepository.GetById(id);
                return questionProposé;
            }

            IEnumerable<QuestionPoposée> IQuestionProposéeService.GetQuestionsProposées()
            {
                var questionsProposés = utOfWork.QuestionProposéeRepository.GetAll();
                return questionsProposés;
            }

            void IQuestionProposéeService.SaveQuestionProposée()
            {
                utOfWork.Commit();
            }

            void IQuestionProposéeService.UpdateQuestionProposée(QuestionPoposée questionProposé)
            {
                utOfWork.QuestionProposéeRepository.Update(questionProposé);
            }

            void IQuestionProposéeService.UpdateQuestionProposéeDetached(QuestionPoposée questionProposé)
            {
                utOfWork.QuestionProposéeRepository.UpdateQuestionPoposéeDetached(questionProposé);
            }
        }
    }
