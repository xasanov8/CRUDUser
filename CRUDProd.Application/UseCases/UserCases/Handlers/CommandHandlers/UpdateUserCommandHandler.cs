using CRUDProd.Application.Abstraction;
using CRUDProd.Application.UseCases.UserCases.Commands;
using CRUDProd.Domain.Entities.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProd.Application.UseCases.UserCases.Handlers.CommandHandlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, User>
    {
        private readonly IUserDbContext _context;
        private readonly IMediator _mediator;

        public UpdateUserCommandHandler(IUserDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (user is not null)
            {
                user.Login = request.Login;
                user.Password = request.Password;

                await _context.SaveChangesAsync(cancellationToken);

                return user;
            }

            return null;
        }
    }
}
