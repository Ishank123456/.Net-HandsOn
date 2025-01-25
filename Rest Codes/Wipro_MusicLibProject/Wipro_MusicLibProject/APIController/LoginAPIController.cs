using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using Wipro_MusicLibProject.DTO;

namespace Wipro_MusicLibProject.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginAPIController : ControllerBase
    {
        ILoginRepository loginRepository;
        public LoginAPIController(ILoginRepository _loginRepository)
        {
            loginRepository = _loginRepository;
        }

        [HttpGet("CheckListOfUsers")]
        public ActionResult CheckListOfUsers()
        {
            List<UserLoginDTO> lstUser = new List<UserLoginDTO>();
            loginRepository.GetUsers().ToList().ForEach(u =>
            {
                UserLoginDTO userLoginDTO = null;
                userLoginDTO = new UserLoginDTO()
                {
                    Id = u.UserId,
                    Password = u.Password,
                    Email = u.Email,
                    ArtistId = u.ArtistId,
                    IsAdmin = u.IsAdmin,
                };
                lstUser.Add(userLoginDTO);
            });
            return Ok(lstUser);
        }
    }
}
