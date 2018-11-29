using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CoachIT.Data.Infrastructure;
using CoachIT.Domain.Entities;

namespace CoachIT.Service
{
    public interface IUserService
    {
        IEnumerable<Candidat> GetCandidats();
        IEnumerable<MoralUser> GetMoralUsers();
        IEnumerable<Administrateur> GetAdministrateurs();
        IEnumerable<User> GetUsers();
        //IEnumerable<User> GetUserByFunction(string function);

        Candidat GetCandidat(int id);
        MoralUser GetMoralUser(int id);
        Administrateur GetAdministrateur(int id);
        User GetUser(int id);

        int GetByLogin(User user);
        void CreateCandidat(Candidat a);
        void CreateUser(User a);
        void CreateMoralUser(MoralUser a);
        void CreateAdministrateur(Administrateur a);

        void DeleteUser(int id);
        void SaveUser();

        void UpdateAdministrateurDetached(Administrateur e);
        void UpdateMoralUserDetached(MoralUser e);
        void UpdateCandidatDetached(Candidat e);
    }

    public class UserService : IUserService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);


        public UserService()
        {

        }

        int IUserService.GetByLogin(User user)
        {
            return utOfWork.UserRepository.GetByLogin(user);
        }

        void IUserService.CreateAdministrateur(Administrateur a)
        {
            utOfWork.UserRepository.Add(a);
        }

        void IUserService.CreateCandidat(Candidat a)
        {
            utOfWork.UserRepository.Add(a);
        }

        void IUserService.CreateUser(User a)
        {
    
            utOfWork.UserRepository.Add(a);

        }


        void IUserService.CreateMoralUser(MoralUser a)
        {
            utOfWork.UserRepository.Add(a);
            
        }

        void IUserService.DeleteUser(int id)
        {
            var user = utOfWork.UserRepository.GetById(id);
            utOfWork.UserRepository.Delete(user);

        }

        Administrateur IUserService.GetAdministrateur(int id)
        {
            var admin = utOfWork.UserRepository.GetById(id) as Administrateur;
            return admin;

        }

        IEnumerable<Administrateur> IUserService.GetAdministrateurs()
        {
            var administrateurs = utOfWork.UserRepository.GetAll().OfType<Administrateur>();
            return administrateurs;

        }

        Candidat IUserService.GetCandidat(int id)
        {
            var candidat = utOfWork.UserRepository.GetById(id) as Candidat;
            return candidat;
        }

        IEnumerable<Candidat> IUserService.GetCandidats()
        {
            var candidats = utOfWork.UserRepository.GetAll().OfType<Candidat>();
            return candidats;
        }

        MoralUser IUserService.GetMoralUser(int id)
        {
            var moralUser = utOfWork.UserRepository.GetById(id) as MoralUser;
            return moralUser;
        }

        IEnumerable<MoralUser> IUserService.GetMoralUsers()
        {
            var moralUsers = utOfWork.UserRepository.GetAll().OfType<MoralUser>();
            return moralUsers;
        }

        User IUserService.GetUser(int id)
        {
            var user = utOfWork.UserRepository.GetById(id) as User;
            return user;
        }

        IEnumerable<User> IUserService.GetUsers()
        {
            var users = utOfWork.UserRepository.GetAll().OfType<User>();
            return users;
        }
        
            
        void IUserService.SaveUser()
        {
            utOfWork.Commit();
        }

        void IUserService.UpdateAdministrateurDetached(Administrateur e)
        {
            utOfWork.UserRepository.UpdateAdministrateurDetached(e);
        }

         void IUserService.UpdateCandidatDetached(Candidat e)
        {
            utOfWork.UserRepository.UpdateCandidatDetached(e);
        }

        void IUserService.UpdateMoralUserDetached(MoralUser e)
        {
            utOfWork.UserRepository.UpdateMoralUserDetached(e);
        }




        //public IEnumerable<User> GetProductsByFunction(string Function)
        //{
        //    var category = utOfWork.UserRepository.Get(x => x.Name == categoryName);
        //    var Products = utOfWork.user.GetMany(x => x.CategoryId == category.CategoryId);
        //    return Products;
        //}

    }
}