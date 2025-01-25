using DAL.EntityFramework;
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
        private readonly ApplicationDbContext applicationDbContext;
        public UserRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public int DeleteUser(int id)
        {
            UserProfile userProfile = applicationDbContext.UserProfiles.SingleOrDefault(x => x.Id == id);
            applicationDbContext.UserProfiles.Remove(userProfile);

            User user = applicationDbContext.Users.SingleOrDefault(x => x.Id == id);
            applicationDbContext.Users.Remove(user);
            return applicationDbContext.SaveChanges();
        }

        public User GetUser(long id)
        {
            return applicationDbContext.Users.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return applicationDbContext.Users.ToList();
        }

        public int InsertUser(User user)
        {
            applicationDbContext.Users.Add(user);
            return applicationDbContext.SaveChanges();
        }

        public int UpdateUser(User user)
        {
            applicationDbContext.Users.Update(user);
            return applicationDbContext.SaveChanges();
        }
    }
}
