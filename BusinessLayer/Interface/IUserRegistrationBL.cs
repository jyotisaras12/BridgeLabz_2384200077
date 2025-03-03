using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IUserRegistrationBL
    {
        bool LoginUser(LoginDTO loginDTO);
        RegistrationDTO RegistrationBL(RegistrationDTO registrationDTO);
    }
}
