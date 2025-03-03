using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Interface
{
    public interface IUserRegistrationRL
    {
        UserEntity GetUserByEmail(string Email);
        RegistrationDTO Registration(RegistrationDTO registrationDTO);

    }
}
