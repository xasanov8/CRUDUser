using CRUDProd.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProd.Application.UseCases.UserCases.Commands
{
    public class CreateUserCommand : IRequest<ResponseModel>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
