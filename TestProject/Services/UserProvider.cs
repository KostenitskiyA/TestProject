using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.Context;
using TestProject.Interfaces;
using TestProject.Models;

namespace TestProject.Services
{
    public class UserProvider : IUserProvider
    {
        private ApplicationContext _db;

        public UserProvider(ApplicationContext context) 
        {
            _db = context;
        }

        public void AddUsers(IEnumerable<User> users)
        {
            try
            {
                _db.Users.AddRange(users);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Dictionary<int, double> CalculateUsers()
        {
            Dictionary<int, double> result = new Dictionary<int, double>();

            for (var i = 0; i < 7; i++)
            {
                var users = _db.Users.ToList();

                var users1 = new List<User>();
                var users2 = new List<User>();

                foreach (var user in users)
                {
                    if (user.LastActivityDate.Subtract(user.RegistrationDate).TotalDays >= i + 1)
                        users1.Add(user);

                    if (DateTime.Now.Subtract(user.RegistrationDate).TotalDays >= i + 1)
                        users2.Add(user);
                }

                double stat = 0;

                if ((double)users1.Count > 0 && (double)users2.Count > 0) 
                {
                    stat += (double)users1.Count;
                    stat /= (double)users2.Count;
                }

                if (stat > 0)
                    stat *= 100;

                result.Add(i + 1, Math.Round(stat, 2));
            }

            return result;
        }
    }
}
