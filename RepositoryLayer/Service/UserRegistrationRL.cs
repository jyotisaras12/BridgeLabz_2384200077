using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        private readonly UserRegistrationApplicationContext _dbContext;

        public UserRegistrationRL(UserRegistrationApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserEntity GetUserByEmail(string Email)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Email == Email);
        }

        public RegistrationDTO Registration(RegistrationDTO registrationDTO)
        {
            if (registrationDTO == null)
                throw new ArgumentNullException(nameof(registrationDTO));

            // Check if the user already exists
            var existingUser = _dbContext.Users.FirstOrDefault(e => e.Email == registrationDTO.Email);
            if (existingUser != null)
            {
                return new RegistrationDTO
                {
                    FirstName = existingUser.FirstName,
                    LastName = existingUser.LastName,
                    Email = existingUser.Email,
                    Password = existingUser.Password
                };
            }

            // Create a new user entity
            var newUser = new UserEntity
            {
                FirstName = registrationDTO.FirstName,
                LastName = registrationDTO.LastName,
                Email = registrationDTO.Email,
                Password = registrationDTO.Password  
            };

            // Add new user to the database
            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();  // Save changes to the database
            return new RegistrationDTO
            {
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Email = newUser.Email,
                Password = newUser.Password
            };
        }
    }
}
