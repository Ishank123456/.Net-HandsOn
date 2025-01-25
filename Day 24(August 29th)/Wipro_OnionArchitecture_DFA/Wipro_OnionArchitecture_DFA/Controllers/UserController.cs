using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using Wipro_OnionArchitecture_DFA.DTO;

namespace Wipro_OnionArchitecture_DFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository iUserRepository;
        private readonly IUserProfileRepository iUserProfileRepository;
        public UserController(IUserRepository _iUserRepository,
            IUserProfileRepository _iUserProfileRepository)
        {
            iUserRepository = _iUserRepository;
            iUserProfileRepository = _iUserProfileRepository;
        }

        [HttpPost("CreateUser")]
        public int CreateUser(CreateUserDTO model)
        {
            User userEntity = new User();
            userEntity.UserName = model.UserName;
            userEntity.Email = model.Email;
            userEntity.Password = model.Password;
            userEntity.ModifiedDate = DateTime.UtcNow;
            userEntity.Ipaddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            iUserRepository.InsertUser(userEntity);

            /*UserProfile userProfile = new UserProfile();
            userProfile.UserId = userEntity.UserId;
            userProfile.FirstName = model.FirstName;
            userProfile.LastName = model.LastName;
            userProfile.Address = model.Address;
            userProfile.ContactNo = model.ContactNo;
            iUserProfileRepository.InsertUser(userProfile);

            userEntity.UserProfiles.Add(userProfile);*/

            return 1;
        }

        public int CreateUserProfile(CreateUserDTO model)
        {
            var lstUsers = iUserRepository.GetUsers().ToList();
            foreach(var u in lstUsers)
            {
                UserProfile userProfile = new UserProfile();
                userProfile.UserId = u.UserId;
                userProfile.FirstName = model.FirstName;
                userProfile.LastName = model.LastName;
                userProfile.Address = model.Address;
                userProfile.ContactNo = model.ContactNo;
                iUserProfileRepository.InsertUser(userProfile);

                u.UserProfiles.Add(userProfile);

            }
            return 1;
        }

        [HttpPut("UpdateUser")]
        public int UpdateUser(CreateUserDTO model)
        {
            User userEntity = new User();
            userEntity.UserName = model.UserName;
            userEntity.Email = model.Email;
            userEntity.Password = model.Password;
            userEntity.ModifiedDate = DateTime.UtcNow;
            userEntity.Ipaddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            iUserRepository.UpdateUser(userEntity);

            UserProfile userProfile = new UserProfile();
            userProfile.UserId = userEntity.UserId;
            userProfile.FirstName = model.FirstName;
            userProfile.LastName = model.LastName;
            userProfile.Address = model.Address;
            userProfile.ContactNo = model.ContactNo;
            iUserProfileRepository.UpdateUser(userProfile);

            return 1;
        }

        /*[HttpGet("ListUsers")]
        public ActionResult ListUsers()
        {
            List<User> lstUser = new List<User>();
            var lstUsers = iUserRepository.GetUsers().ToList();
            foreach (var u in lstUsers)
            {
                User user = new User();
                UserProfile userProfile = iUserProfileRepository.GetUserProfile(u.UserId);
                user.UserId = u.UserId;
                user.UserName = u.UserName;
                user.Email = u.Email;
                user.Password = u.Password;
                user.ModifiedDate = u.ModifiedDate;
                user.Ipaddress = u.Ipaddress;

                user.UserProfiles = u.UserProfiles;
                foreach(var uP in u.UserProfiles)
                {
                    userProfile.FirstName = uP.FirstName;
                    userProfile.LastName = uP.LastName;
                    userProfile.Address = uP.Address;
                    userProfile.ContactNo = uP.ContactNo;
                }
                lstUser.Add(user);
            }
            return Ok(lstUser);
        }*/
    }
}
