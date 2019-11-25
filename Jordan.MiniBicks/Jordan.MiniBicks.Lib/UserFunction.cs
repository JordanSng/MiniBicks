using System;
using System.Collections.Generic;
using System.Text;
using Jordan.MiniBicks.Data;
using Jordan.MiniBicks.Data.Models;

namespace Jordan.MiniBicks.Lib
{
    public class UserFunction
    {
        public void CreateUser(string nom,string prenom,string password)
        {
            using (var bickContext = new BicksContext())
            {
                User user = new User();
                user.FirstName = nom;
                user.LastName = prenom;
                user.Password = password;

                bickContext.Users.Add(user);
                bickContext.SaveChanges();
            }

        }
    }
}
