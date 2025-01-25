using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SmartHmsdbContext userDbContext;
        public UserRepository(SmartHmsdbContext _userDbContext)
        {
            userDbContext = _userDbContext;
        }

        public int AddUser(User user)
        {
            userDbContext.Users.Add(user);
            return userDbContext.SaveChanges();
        }

        public bool DeleteUser(int id)
        {
            var filterData = userDbContext.Users.SingleOrDefault(u => u.UserId == id);
            var result = userDbContext.Users.Remove(filterData);
            userDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return userDbContext.Users.ToList();
        }

        public User GetUser(int id)
        {
            return userDbContext.Users.SingleOrDefault(u => u.UserId == id);
        }

        public int UpdateUser(User user)
        {
            userDbContext.Users.Update(user);
            return userDbContext.SaveChanges();
        }
    }
}
