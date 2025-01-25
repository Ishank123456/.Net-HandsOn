using Domain.DAL;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Wipro29082024Context userDbContext;
        public UserRepository(Wipro29082024Context _userDbContext)
        {
            userDbContext = _userDbContext;
        }
        public void DeleteUser(int id)
        {
            UserProfile userProfile = userDbContext.UserProfiles.SingleOrDefault(u => u.UserProfileId == id);
            userDbContext.UserProfiles.Remove(userProfile);

            User user = userDbContext.Users.SingleOrDefault(u => u.UserId == id);
            userDbContext.Users.Remove(user);
            userDbContext.SaveChanges();
        }

        public User GetUser(int id)
        {
            return userDbContext.Users.FirstOrDefault(u => u.UserId == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return userDbContext.Users.ToList();
        }

        public void InsertUser(User user)
        {
            userDbContext.Users.Add(user);
            userDbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            userDbContext.Users.Update(user);
            userDbContext.SaveChanges();
        }
    }
}
