using CRUDProd.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProd.Application.UseCases.UserCases.Commands
{
    public class DeleteUserCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
    }
}
