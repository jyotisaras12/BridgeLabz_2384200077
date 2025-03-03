using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using BusinessLayer.Interface;
using BusinessLayer.Service;

namespace UserRegistrationApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationApplicationController : ControllerBase
    {
        private readonly IUserRegistrationBL _registrationBL;
        private readonly ILogger<UserRegistrationApplicationController> _logger;
        ResponseModel<RegistrationDTO> response;
        ResponseModel<LoginDTO> loginResponse;

        public UserRegistrationApplicationController(IUserRegistrationBL registrationBL, ILogger<UserRegistrationApplicationController> logger)
        {
            _registrationBL = registrationBL;
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Get request received.");
            return "User Registration Process...";
        }

        [HttpPost]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            try
            {
                _logger.LogInformation("Login attempt for user: {FirstName}", loginDTO.FirstName);
                loginResponse = new ResponseModel<LoginDTO>();
                bool result = _registrationBL.LoginUser(loginDTO);
                if (result)
                {
                    loginResponse.Success = true;
                    loginResponse.Message = "Login Successful!";
                    return Ok(loginResponse);
                }

                loginResponse.Success = false;
                loginResponse.Message = "Login Failed!";

                return NotFound(loginResponse);
            }
            catch (Exception ex)
            {
                loginResponse.Success = false;
                loginResponse.Message = "Login Failed";
                _logger.LogError(ex, "Exception in LoginUser method");
                return BadRequest(loginResponse);
            }
        }

        [HttpPost]
        [Route("register")]

        public IActionResult RegistrationUser(RegistrationDTO registrationDTO)
        {
            var result = _registrationBL.RegistrationBL(registrationDTO);
            response = new ResponseModel<RegistrationDTO>();
            response.Success = true;
            response.Message = "Registration Successful!";
            response.Data = result;
            return Created("User created", result);
        }
    }
}