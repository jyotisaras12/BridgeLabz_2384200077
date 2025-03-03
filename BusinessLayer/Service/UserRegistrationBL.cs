using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Service;
using RepositoryLayer.Interface;
using BusinessLayer.Interface;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL : IUserRegistrationBL
    {
        private readonly IUserRegistrationRL _registrationRL;
        public UserRegistrationBL(IUserRegistrationRL registrationRL)
        {
            _registrationRL = registrationRL;
        }
        public bool LoginUser(LoginDTO loginDTO)
        {
            if(loginDTO == null)
            {
                return false;
            }
            // Fetch user from database by email
            var existingUser = _registrationRL.GetUserByEmail(loginDTO.Email);

            if (existingUser == null)
            {
                return false; 
            }

            return existingUser.Password == loginDTO.Password;
        }

        public RegistrationDTO RegistrationBL(RegistrationDTO registrationDTO)
        {
            var result = _registrationRL.Registration(registrationDTO);
            if (result == null)
                return null;

            // Map UserEntity to RegisterResponseDTO
            return new RegistrationDTO
            {
                FirstName = result.FirstName,
                LastName = result.LastName,
                Email = result.Email,
                Password = result.Password
            };
        }
    }
}
