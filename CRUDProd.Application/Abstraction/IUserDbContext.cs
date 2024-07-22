using CRUDProd.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProd.Application.Abstraction
{
    public interface IUserDbContext
    {
        public DbSet<User> Users { get; set; } 

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
