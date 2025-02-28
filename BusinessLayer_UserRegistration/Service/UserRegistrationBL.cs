using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer_UserRegistration.DTO;
using RepositoryLayer_UserRegistration.Service;

namespace BusinessLayer_UserRegistration.Service
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _userRegistrationRL;
        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public bool RegistrationBL(RegistrationDTO registrationDTO)
        {
            string frontendUserName = registrationDTO.username;
            string frontendEmail = registrationDTO.email;
            string frontendPassword = registrationDTO.password;

            List<RegistrationDTO> result = _userRegistrationRL.GetUserDetails();

            bool res = CheckUserDetails(frontendUserName, frontendEmail, frontendPassword, result);
            return res;
        }

        public bool CheckUserDetails(string frontendUserName, string frontendEmail, string frontendPassword, List<RegistrationDTO> result)
        {
            return result.Any(user => user.username.Equals(frontendUserName) && user.email.Equals(frontendEmail) && user.password.Equals(frontendPassword));
        }
    }
}
