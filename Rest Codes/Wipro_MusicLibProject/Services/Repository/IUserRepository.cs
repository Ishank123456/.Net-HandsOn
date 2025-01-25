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
        User GetUser(int id);
        int InsertUser (User user);
        int UpdateUser (User user);
        void DeleteUser (long id); 
    }
}
