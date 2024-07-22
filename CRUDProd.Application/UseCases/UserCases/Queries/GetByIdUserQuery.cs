using CRUDProd.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProd.Application.UseCases.UserCases.Queries
{
    public class GetByIdUserQuery : IRequest<User>
    {
        public Guid Id { get; set; }
    }
}
