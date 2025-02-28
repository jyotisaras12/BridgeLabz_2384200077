using Microsoft.AspNetCore.Mvc;
using BusinessLayer_UserRegistration.Service;
using ModelLayer_UserRegistration.DTO;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {

        UserRegistrationBL _userRegistrationBL;
        ResponseModel<string> response;

        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpGet]
        public string Get()
        {
            return "User Registration Process...";
        }

        [HttpPost]
        public IActionResult Post(RegistrationDTO registrationDTO)
        {
            try
            {
                response = new ResponseModel<string>();
                bool result = _userRegistrationBL.RegistrationBL(registrationDTO);
                if (result)
                {
                    response.Success = true;
                    response.Message = "Login Successful!";
                    response.Data = registrationDTO.username;
                    return Ok(response);
                }

                response.Success = false;
                response.Message = "Login Failed!";
                response.Data = "";

                return NotFound(response);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Login Failed";
                response.Data = ex.Message;
                return BadRequest(response);
            }
        }
    }
}
