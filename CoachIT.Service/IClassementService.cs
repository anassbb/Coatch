using System.Collections.Generic;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Service
{
    public interface IClassementService
    {
        IEnumerable<Classement> GetClassements();
        Classement GetClassement(int id);
        void CreateClassement(Classement classement);
        void DeleteClassement(int id);
        void SaveClassement();
        void UpdateClassement(Classement classement);
        void UpdateClassementDetached(Classement classement);
    }

    public class ClassementService : IClassementService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public ClassementService()
        {

        }

        void IClassementService.CreateClassement(Classement classement)
        {
            utOfWork.ClassementRepository.Add(classement);
        }

        void IClassementService.DeleteClassement(int id)
        {
            var classement = utOfWork.ClassementRepository.GetById(id);
            utOfWork.ClassementRepository.Delete(classement);
        }

        Classement IClassementService.GetClassement(int id)
        {
            var classement = utOfWork.ClassementRepository.GetById(id);
            return classement;
        }

        IEnumerable<Classement> IClassementService.GetClassements()
        {
            var classements = utOfWork.ClassementRepository.GetAll();
            return classements;
        }

        void IClassementService.SaveClassement()
        {
            utOfWork.Commit();
        }

        void IClassementService.UpdateClassement(Classement classement)
        {
            utOfWork.ClassementRepository.Update(classement);
        }

        void IClassementService.UpdateClassementDetached(Classement classement)
        {
            utOfWork.ClassementRepository.UpdateClassementDetached(classement);
        }
    }
}