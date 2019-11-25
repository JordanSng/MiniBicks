using System;
using System.Linq;
using Jordan.MiniBicks.Data;
using Jordan.MiniBicks.Data.Models;

namespace Jordan.MiniBicks.Lib
{
    public class UserFunction
    {
        public void CreateUser(string nom,string prenom, string usernname,string adresse,string password)
        {
            using (var bickContext = new BicksContext())
            {
                User user = new User();
                user.FirstName = nom;
                user.LastName = prenom;
                user.Username = usernname;
                user.Address = adresse;
                user.Password = password;

                bickContext.Users.Add(user);
                bickContext.SaveChanges();
            }

        }

        public bool Login(string username, string password)
        {
            using (var bickContext = new BicksContext())
            {
                var user = from p in bickContext.Users
                    where p.Username == username && p.Password == password
                    select p;

                if (user.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public int GetUserId(string username, string password)
        {
            using (var bicksContext = new BicksContext())
            {
                var userId = from p in bicksContext.Users
                    where p.Username == username && p.Password == password
                    select p.UserId;

                int idUser = userId.First();
                return idUser;
            }
        }

        public void CreateAbs(int userId, string justificatif, int absenceId)
        {
            using (var bickContext = new BicksContext())
            {
                AbsenceUser absenceUser = new AbsenceUser();
                absenceUser.UserId = userId;
                absenceUser.Justificatif = justificatif;
                absenceUser.AbsenceId = absenceId;

                bickContext.AbsenceUsers.Add(absenceUser);
                bickContext.SaveChanges();
            }
        }
    }
}
