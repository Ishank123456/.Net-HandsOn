using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly SmartHmsdbContext userLoginDbContext;
        public LoginRepository(SmartHmsdbContext _userLoginDbContext)
        {
            userLoginDbContext = _userLoginDbContext;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return userLoginDbContext.Users.ToList();
        }
    }
}

