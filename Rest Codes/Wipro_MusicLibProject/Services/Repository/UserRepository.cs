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
        public void DeleteUser(long id)
        {
            var user = applicationDbContext.Users.SingleOrDefault(u => u.UserId == id);
            var userDelete = applicationDbContext.Users.Remove(user);
            applicationDbContext.SaveChanges();
        }

        public User GetUser(int id)
        {
            return applicationDbContext.Users.SingleOrDefault(u => u.UserId == id);
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
