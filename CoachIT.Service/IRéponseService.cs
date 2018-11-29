using System.Collections.Generic;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Service
{
    public interface IRéponseService
    {
        IEnumerable<Réponse> GetRéponses();
        Réponse GetRéponse(int id);
        void CreateRéponse(Réponse réponse);
        void DeleteRéponse(int id);
        void SaveRéponse();
        void UpdateRéponse(Réponse réponse);
        void UpdateRéponseDetached(Réponse réponse);
    }

    public class RéponseService : IRéponseService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public RéponseService()
        {

        }

        void IRéponseService.CreateRéponse(Réponse réponse)
        {
            utOfWork.RéponseRepository.Add(réponse);
        }

        void IRéponseService.DeleteRéponse(int id)
        {
            var réponseQuestionProposée = utOfWork.RéponseRepository.GetById(id);
            utOfWork.RéponseRepository.Delete(réponseQuestionProposée);
        }

        Réponse IRéponseService.GetRéponse(int id)
        {
            var réponse = utOfWork.RéponseRepository.GetById(id);
            return réponse;
        }

        IEnumerable<Réponse> IRéponseService.GetRéponses()
        {
            var réponses = utOfWork.RéponseRepository.GetAll();
            return réponses;
        }

        void IRéponseService.SaveRéponse()
        {
            utOfWork.Commit();
        }

        void IRéponseService.UpdateRéponse(Réponse réponse)
        {
            utOfWork.RéponseRepository.Update(réponse);
        }

        void IRéponseService.UpdateRéponseDetached(Réponse réponse)
        {
            utOfWork.RéponseRepository.UpdateRéponseDetached(réponse);
        }
    }
}