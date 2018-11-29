using System.Collections.Generic;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Service
{
    public interface IRéponseQuestionProposéeService
    {
        IEnumerable<RéponseQuestionProposée> GetRéponsesQuestionsProposées();
        RéponseQuestionProposée GetRéponseQuestionProposé(int id);
        void CreateRéponseQuestionProposée(RéponseQuestionProposée réponseQuestionProposée);
        void DeleteRéponseQuestionProposée(int id);
        void SaveRéponseQuestionProposée();
        void UpdateRéponseQuestionProposée(RéponseQuestionProposée réponseQuestionProposée);
        void UpdateRéponseQuestionProposéeDetached(RéponseQuestionProposée réponseQuestionProposée);
    }

    public class RéponseQuestionProposéeService : IRéponseQuestionProposéeService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public RéponseQuestionProposéeService()
        {

        }

        void IRéponseQuestionProposéeService.CreateRéponseQuestionProposée(RéponseQuestionProposée réponseQuestionProposée)
        {
            utOfWork.RéponseQuestionProposéeRepository.Add(réponseQuestionProposée);
        }

        void IRéponseQuestionProposéeService.DeleteRéponseQuestionProposée(int id)
        {
            var réponseQuestionProposée = utOfWork.RéponseQuestionProposéeRepository.GetById(id);
            utOfWork.RéponseQuestionProposéeRepository.Delete(réponseQuestionProposée);
        }

        RéponseQuestionProposée IRéponseQuestionProposéeService.GetRéponseQuestionProposé(int id)
        {
            var réponseQuestionProposée = utOfWork.RéponseQuestionProposéeRepository.GetById(id);
            return réponseQuestionProposée;
        }

        IEnumerable<RéponseQuestionProposée> IRéponseQuestionProposéeService.GetRéponsesQuestionsProposées()
        {
            var réponseQuestionProposées = utOfWork.RéponseQuestionProposéeRepository.GetAll();
            return réponseQuestionProposées;
        }

        void IRéponseQuestionProposéeService.SaveRéponseQuestionProposée()
        {
            utOfWork.Commit();
        }

        void IRéponseQuestionProposéeService.UpdateRéponseQuestionProposée(RéponseQuestionProposée réponseQuestionProposée)
        {
            utOfWork.RéponseQuestionProposéeRepository.Update(réponseQuestionProposée);
        }

        void IRéponseQuestionProposéeService.UpdateRéponseQuestionProposéeDetached(RéponseQuestionProposée réponseQuestionProposée)
        {
            utOfWork.RéponseQuestionProposéeRepository.UpdateRéponseQuestionProposéeDetached(réponseQuestionProposée);
        }
    }
}