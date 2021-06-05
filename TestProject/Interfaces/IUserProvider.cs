using System.Collections.Generic;
using TestProject.Models;

namespace TestProject.Interfaces
{
    public interface IUserProvider
    {
        /// <summary>
        /// Добавление пользователей
        /// </summary>
        /// <param name="users">Коллекция пользователей</param>
        public void AddUsers(IEnumerable<User> users);

        /// <summary>
        /// Расчёт пользователей
        /// </summary>
        public Dictionary<int, double> CalculateUsers();
    }
}
