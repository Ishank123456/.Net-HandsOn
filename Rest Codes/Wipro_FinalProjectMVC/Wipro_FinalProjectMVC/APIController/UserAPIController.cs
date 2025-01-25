using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using Wipro_FinalProjectMVC.DTO;

namespace Wipro_FinalProjectMVC.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        IUserRepository iUserRepository;
        IUserProfileRepository iUserProfileRepository;
        private readonly IMapper mapper;
        public UserAPIController(IUserRepository _iUserRepository,
            IUserProfileRepository _iUserProfileRepository, IMapper _mapper)
        {
            iUserRepository = _iUserRepository;
            iUserProfileRepository = _iUserProfileRepository;
            mapper = _mapper;
        }

        [HttpPost("Create")]
        public int CreateUser(UserDTOCreate model)
        {
            User userEntity = new User()
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                ModifiedDate = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                Profile = new UserProfile()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    ContactNo = model.ContactNo,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            iUserRepository.InsertUser(userEntity);
            return 1;
        }

        [HttpPut("Update")]
        public int UpdateUser(UserDTO model)
        {
            User userEntity = new User()
            {
                Id = model.Id,
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                ModifiedDate = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                Profile = new UserProfile()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    ContactNo = model.ContactNo,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            iUserRepository.UpdateUser(userEntity);
            return 1;
        }

        [HttpDelete("Delete")]
        public int DeleteUser(int id)
        {
            iUserRepository.DeleteUser(id);
            return 1;
        }

        [HttpGet("ListUsers")]
        public ActionResult ListUsers()
        {
            List<UserDTO> lstUser = new List<UserDTO>();
            iUserRepository.GetUsers().ToList().ForEach(u =>
            {
                UserDTO userDTO = null;
                UserProfile userProfile = iUserProfileRepository.GetUserProfile(u.Id);
                userDTO = new UserDTO()
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    Email = u.Email,
                    Password = u.Password,
                    ModifiedDate = u.ModifiedDate,
                    FirstName = userProfile.FirstName,
                    LastName = userProfile.LastName,
                    Name = $"{userProfile.FirstName} {userProfile.LastName}",
                    ContactNo = userProfile.ContactNo,
                    Address = userProfile.Address,
                };
                lstUser.Add(userDTO);
            });
            return Ok(lstUser);
        }
    }
}
