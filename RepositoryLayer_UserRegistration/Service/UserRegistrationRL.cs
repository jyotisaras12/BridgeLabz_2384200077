using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer_UserRegistration.DTO;

namespace RepositoryLayer_UserRegistration.Service
{
    public class UserRegistrationRL
    {
        List<RegistrationDTO> list = new List<RegistrationDTO>();
        RegistrationDTO user1 = new RegistrationDTO("user1", "email1@gmail.com", "password1");
        RegistrationDTO user2 = new RegistrationDTO("user2", "email2@gla.ac.in", "password2");
        RegistrationDTO user3 = new RegistrationDTO("user3", "email3@gmail.com", "password3");

        public UserRegistrationRL()
        {
            list.Add(user1);
            list.Add(user2);
            list.Add(user3);
        }

        public List<RegistrationDTO> GetUserDetails()
        {
            return list;
        }
    }
}
