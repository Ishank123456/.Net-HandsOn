using DAL.EntityFramework;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public LoginRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return applicationDbContext.Users.ToList();
        }
    }
}
