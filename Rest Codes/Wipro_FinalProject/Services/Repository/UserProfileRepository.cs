using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_FinalProject.Models;

namespace Services.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public UserProfileRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public UserProfile GetUserProfile(long id)
        {
            return applicationDbContext.UserProfiles.FirstOrDefault(s => s.Id == id);
        }
    }
}
