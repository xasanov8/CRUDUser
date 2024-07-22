using CRUDProd.Application.Abstraction;
using CRUDProd.Application.UseCases.UserCases.Commands;
using CRUDProd.Domain.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProd.Application.UseCases.UserCases.Handlers.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, ResponseModel>
    {
        private readonly IUserDbContext _context;
        private readonly IMediator _mediator;

        public CreateUserCommandHandler(IUserDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<ResponseModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var user = new User
                {
                    Login = request.Login,
                    Password = request.Password
                };

                await _context.Users.AddAsync(user, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    Message = $"{request.Login} => User Created",
                    isSucces = true
                };
            }

            return new ResponseModel
            {
                Message = "Catalog is maybe null",
                StatusCode = 400
            };
        }
    }
}
