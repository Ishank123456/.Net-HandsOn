using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);
        int InsertUser(User user);
        int UpdateUser(User user);
        int DeleteUser(int id);
    }
}
