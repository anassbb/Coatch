using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CoachIT.Domain.Entities;


namespace CoachIT.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {

        public UserConfiguration()
        {
            // Primal Key
            HasKey(t => t.UserId);


            // Properties

            Property(t => t.Login).IsRequired().HasMaxLength(30);
            Property(t => t.Password).IsRequired();



            // Table & Column Mappings

            ToTable("Utilisateurs");

            Property(t => t.UserId).HasColumnName("ID User");
            Property(t => t.Login).HasColumnName("login");
            Property(t => t.Password).HasColumnName("Mot de passe");
            Property(t => t.InscriptionDate).HasColumnName("Date Inscription ");
            Property(t => t.LastActivityDate).HasColumnName("Date Last Activity ");
            Property(t => t.LastPasswordChangeDate).HasColumnName("Date de changement de MDP ");
            Property(t => t.Statu).HasColumnName("Activer/Désactiver ");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Phonenumber).HasColumnName("Téléphone");
            Property(t => t.Adress).HasColumnName("Adresse");


            // TPH Inheritance 

            Map<Candidat>(c =>
            {
                c.Requires("UserType").HasValue("Candidat");
            })
                .Map<Administrateur>(c =>
                {
                    c.Requires("UserType").HasValue("Administrateur");
                })
                .Map<MoralUser>(c =>
                {
                    c.Requires("UserType").HasValue("Entreprise");
                });
        }
    }
}
