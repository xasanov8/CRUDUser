using CRUDProd.Application.Abstraction;
using CRUDProd.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProd.Infrostucture.References
{
    public class UserDbContext : DbContext, IUserDbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
           : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
    }
}
