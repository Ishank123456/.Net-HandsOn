using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using Wipro_OnionArchitecture.DTO;

namespace Wipro_OnionArchitecture.Controllers
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

        [HttpPost("CreateUsers")]
        public int CreateUser(CreateUserDTO model)
        {
            User userEntity = new User();
            userEntity.UserName = model.UserName;
            userEntity.Email = model.Email;
            userEntity.Password = model.Password;
            userEntity.ModifiedDate = DateTime.UtcNow;
            userEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            userEntity.Profile = new UserProfile();
            userEntity.Profile.FirstName = model.FirstName;
            userEntity.Profile.LastName = model.LastName;
            userEntity.Profile.Address = model.Address;
            userEntity.Profile.ContactNo = model.ContactNo;
            userEntity.Profile.ModifiedDate = DateTime.UtcNow;
            userEntity.Profile.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            iUserRepository.InsertUser(userEntity);
            return 1;
        }

        [HttpPut("UpdateUser")]
        public int UpdateUser(UpdateUserDTO model)
        {
            User userEntity = new User();
            userEntity.Id = model.Id;
            userEntity.UserName = model.UserName;
            userEntity.Email = model.Email;
            userEntity.Password = model.Password;
            userEntity.ModifiedDate = DateTime.UtcNow;
            userEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            userEntity.Profile = new UserProfile();
            userEntity.Profile.Id = model.Id;
            userEntity.Profile.FirstName = model.FirstName;
            userEntity.Profile.LastName = model.LastName;
            userEntity.Profile.Address = model.Address;
            userEntity.Profile.ContactNo = model.ContactNo;
            userEntity.Profile.ModifiedDate = DateTime.UtcNow;
            userEntity.Profile.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            iUserRepository.UpdateUser(userEntity);
            return 1;
        }

        [HttpDelete("DeleteUser")]
        public int DeleteUser(int id)
        {
            iUserRepository.DeleteUser(id);
            return 1;
        }

        [HttpGet("ListUsers")]
        public ActionResult ListUsers()
        {
            List<User> lstUser = new List<User>();
            var lstUsers = iUserRepository.GetUsers().ToList();
            foreach(var u in lstUsers)
            {
                User user = new User();
                UserProfile userProfile = iUserProfileRepository.GetUserProfile(u.Id);
                user.Id = u.Id;
                user.UserName = u.UserName;
                user.Email = u.Email;
                user.Password = u.Password;
                user.ModifiedDate = u.ModifiedDate;
                user.IPAddress = u.IPAddress;
                user.Profile = new UserProfile();
                user.Profile.Id = u.Id;
                user.Profile.FirstName = userProfile.FirstName;
                user.Profile.LastName = userProfile.LastName;
                user.Profile.ContactNo = userProfile.ContactNo;
                user.Profile.Address = userProfile.Address;
                user.Profile.ModifiedDate = userProfile.ModifiedDate;
                user.Profile.IPAddress = userProfile.IPAddress;

                lstUser.Add(user);
            }
            return Ok(lstUser);
        }
    }
}
