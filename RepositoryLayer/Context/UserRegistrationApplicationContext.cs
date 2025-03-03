using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Context
{
    public class UserRegistrationApplicationContext : DbContext
    {
        public UserRegistrationApplicationContext(DbContextOptions<UserRegistrationApplicationContext> options) : base(options)
        { }
        public virtual DbSet<UserEntity> Users { get; set; }
    }
}
