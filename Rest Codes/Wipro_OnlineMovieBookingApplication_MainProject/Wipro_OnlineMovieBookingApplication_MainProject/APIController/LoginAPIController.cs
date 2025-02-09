﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using Wipro_OnlineMovieBookingApplication_MainProject.DTO;

namespace Wipro_OnlineMovieBookingApplication_MainProject.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginAPIController : ControllerBase
    {
        ILoginRepository iLoginRepository;
        public LoginAPIController(ILoginRepository _iLoginRepository)
        {
            iLoginRepository = _iLoginRepository;
        }

        [HttpGet("CheckListOfUsers")]
        public ActionResult CheckListOfUsers()
        {
            List<UserLoginDTO> lstUser = new List<UserLoginDTO>();
            iLoginRepository.GetAllUsers().ToList().ForEach(u =>
            {
                UserLoginDTO userLoginDTO = null;
                userLoginDTO = new UserLoginDTO()
                {
                    Id = u.UserId,
                    Email = u.Email,
                    Password = u.Password
                };
                lstUser.Add(userLoginDTO);
            });
            return Ok(lstUser);
        }
    }
}
