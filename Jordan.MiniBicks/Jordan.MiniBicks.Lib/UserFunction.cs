using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jordan.MiniBicks.Data;
using Jordan.MiniBicks.Data.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

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
    }
}
