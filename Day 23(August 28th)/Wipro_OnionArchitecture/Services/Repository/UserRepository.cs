using DAL.EntityFramework;
using Domain.Models;

namespace Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public UserRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public void DeleteUser(int id)
        {
            UserProfile userProfile = applicationDbContext.UserProfiles.SingleOrDefault(x => x.Id == id);
            applicationDbContext.UserProfiles.Remove(userProfile);

            User user = applicationDbContext.Users.SingleOrDefault(x => x.Id == id);
            applicationDbContext.Users.Remove(user);
            applicationDbContext.SaveChanges();
        }

        public User GetUser(long id)
        {
            return applicationDbContext.Users.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return applicationDbContext.Users.ToList();
        }

        public void InsertUser(User user)
        {
            applicationDbContext.Users.Add(user);
            applicationDbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            applicationDbContext.Users.Update(user);
            applicationDbContext.SaveChanges();
        }
    }
}
