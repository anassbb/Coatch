using CoachIT.Domain.Entities;
using System.Collections.Generic;
using CoachIT.Data.Infrastructure;
using System;
using System.Linq;

namespace CoachIT.Service
{
    public interface ICategorieService
    {

        IEnumerable<Catégorie> GetCategories();
        Catégorie GetCategory(int id);
        void CreateCategory(Catégorie category);
        void DeleteCategory(int id);
        void SaveCategory();
        void UpdateCategory(Catégorie category);
        void UpdateCategoryDetached(Catégorie c);
    }
    public class CategoryService : ICategorieService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public CategoryService()
        {

        }
        #region ICategoryService Members

         IEnumerable<Catégorie> ICategorieService.GetCategories()
        {
            var categories = utOfWork.CategorieRepository.GetAll();
            return categories;
        }

        Catégorie ICategorieService.GetCategory(int id)
        {
            var category = utOfWork.CategorieRepository.GetById(id);
            return category;
        }

        void ICategorieService.CreateCategory(Catégorie category)
        {
            utOfWork.CategorieRepository.Add(category);

        }

        void ICategorieService.DeleteCategory(int id)
        {
            var category = utOfWork.CategorieRepository.GetById(id);
            utOfWork.CategorieRepository.Delete(category);


        }
        void ICategorieService.UpdateCategoryDetached(Catégorie c)
        {
            utOfWork.CategorieRepository.UpdateCatégorieDetached(c);
        }


        void ICategorieService.UpdateCategory(Catégorie category)
        {
            utOfWork.CategorieRepository.Update(category);


        }


        void ICategorieService.SaveCategory()
        {
            utOfWork.Commit();
        }

        #endregion

    }

}