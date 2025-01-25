using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice_APIWithView_MVC_Login.DTOs;
using Practice_APIWithView_MVC_Login.Models;
using Practice_APIWithView_MVC_Login.Repository;

namespace Practice_APIWithView_MVC_Login.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        private readonly IUserProfileRepository userProfileRepository;
        private readonly IMapper mapper;
        public UserAPIController(IUserProfileRepository _userProfileRepository, IMapper _mapper)
        {
            userProfileRepository = _userProfileRepository;
            mapper = _mapper;
        }

        [HttpPost("Register")]
        public ActionResult RegisterUser(UserProfile userProfile)
        {
            return Ok(userProfileRepository.RegisterUserProfile(userProfile));
        }

        [HttpGet("GetAllUsers")]
        public ActionResult GetAllUsers()
        {
            return Ok(userProfileRepository.GetAllProfiles());
        }

        [HttpGet("GetUserById")]
        public ActionResult GetUserById(int id)
        {
            return Ok(userProfileRepository.GetProfile(id));
        }

        [HttpPost("Login")]
        public ActionResult LoginUser(UserProfileDTO model)
        {
            return Ok(userProfileRepository.RegisterUserProfile(mapper.Map<UserProfile>(model)));
        }
    }
}
