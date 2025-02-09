﻿using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repositories;
using Wipro_SmartHealthcareSystem_Assesment4.DTOs;

namespace Wipro_SmartHealthcareSystem_Assesment4.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterAPIController : ControllerBase
    {
        private readonly IUserRepository iUserRepository;
        public RegisterAPIController(IUserRepository _iUserRepository)
        {
            iUserRepository = _iUserRepository;
        }
        [HttpPost("Register")]
        public ActionResult UserRegistration(UserDTOCreate model)
        {
            User userEntity = new User()
            {
                UserName = model.UserName,
                Password = model.Password,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                ContactNo = model.ContactNo
            };
            iUserRepository.AddUser(userEntity);
            return Ok(userEntity);
        }
    }
}
