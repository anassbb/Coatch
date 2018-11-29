using System.Collections.Generic;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Service
{
    public interface ISousCategorieService
    {
        IEnumerable<SousCatégorie> GetSousCategories();
        SousCatégorie GetSousCategory(int id);
        void CreateSousCategory(SousCatégorie sousCatégorie);
        void DeleteSousCategory(int id);
        void SaveSousCategory();
        void UpdateSousCategory(SousCatégorie sousCatégorie);
        void UpdateSousCatégorieDetached(SousCatégorie sousCatégorie);
    }

    public class SousCategorieService : ISousCategorieService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public SousCategorieService()
        {

        }

        #region ISousCategoryService Members

        IEnumerable<SousCatégorie> ISousCategorieService.GetSousCategories()
        {
            var souscategories = utOfWork.SousCategorieRepository.GetAll();
            return souscategories;
        }

        SousCatégorie ISousCategorieService.GetSousCategory(int id)
        {
            var souscategorie = utOfWork.SousCategorieRepository.GetById(id);
            return souscategorie;
        }

        void ISousCategorieService.CreateSousCategory(SousCatégorie souscategory)
        {
            utOfWork.SousCategorieRepository.Add(souscategory);

        }

        void ISousCategorieService.DeleteSousCategory(int id)
        {
            var souscategorie = utOfWork.SousCategorieRepository.GetById(id);
            utOfWork.SousCategorieRepository.Delete(souscategorie);


        }

        void ISousCategorieService.UpdateSousCatégorieDetached(SousCatégorie c)
        {
            utOfWork.SousCategorieRepository.UpdateSousCatégorieDetached(c);
        }


        void ISousCategorieService.UpdateSousCategory(SousCatégorie souscategorie)
        {
            utOfWork.SousCategorieRepository.Update(souscategorie);


        }

        void ISousCategorieService.SaveSousCategory()
        {
            utOfWork.Commit();
        }

        #endregion


    }
}
