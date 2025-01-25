using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using Wipro_MusicLibProject.DTO;

namespace Wipro_MusicLibProject.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        IUserRepository userRepository;
        public UserAPIController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }
        [HttpGet("SingleUser")]
        public ActionResult GetSingleUsers(int id)
        {
            UserDTO userDTO = new UserDTO();
            User userEntity = userRepository.GetUser(id);
            userDTO.UserId = userEntity.UserId;
            userDTO.FirstName = userEntity.FirstName;
            userDTO.LastName = userEntity.LastName;
            userDTO.Address = userEntity.Address;
            userDTO.Email = userEntity.Email;
            userDTO.ContactNo = userEntity.ContactNo;
            userDTO.Password = userEntity.Password;
            userDTO.Name = $"{userEntity.FirstName} {userEntity.LastName}";
            userDTO.UserName = userEntity.UserName;
            userDTO.ArtistId = userEntity.ArtistId;
            return Ok(userDTO);
        }

        [HttpGet("ListUsers")]
        public ActionResult ListUsers()
        {
            List<UserDTO> lstUser = new List<UserDTO>();
            userRepository.GetUsers().ToList().ForEach(u =>
            {
                UserDTO userDTO = null;
                userDTO = new UserDTO()
                {
                    UserId = u.UserId,
                    UserName = u.UserName,
                    Email = u.Email,
                    Password = u.Password,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Name = $"{u.FirstName} {u.LastName}",
                    ContactNo = u.ContactNo,
                    Address = u.Address,
                    ArtistId = u.ArtistId
                };
                lstUser.Add(userDTO);
            });
            return Ok(lstUser);
        }

        [HttpPost("CreateUser")]
        public int CreateUser(UserDTOCreate model)
        {
            User userEntity = new User()
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName,
                ContactNo = model.ContactNo,
                Address = model.Address
            };
            userRepository.InsertUser(userEntity);
            return 1;
        }

        [HttpPut("UpdateUser")]
        public int UpdateUser(UserDTO model)
        {
            User userEntity = new User()
            {
                UserId = model.UserId,
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName,
                ContactNo = model.ContactNo,
                Address = model.Address,
                ArtistId = model.ArtistId
            };
            userRepository.UpdateUser(userEntity);
            return 1;
        }

        [HttpDelete("DeleteUser")]
        public bool DeleteUser(int id)
        {
            userRepository.DeleteUser(id);
            return true;
        }
    }
}
