using CRUDProd.Domain.Entities.DTOs;
using CRUDProd.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProd.Application.UseCases.UserCases.Commands
{
    public class UpdateUserCommand : UserDTO, IRequest<User>
    {
        public Guid Id { get; set; }
    }
}
