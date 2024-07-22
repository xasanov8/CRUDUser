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
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, ResponseModel>
    {
        private readonly IUserDbContext _context;
        private readonly IMediator _mediator;

        public DeleteUserCommandHandler(IUserDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<ResponseModel> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    Message = $"{request.Id} => User Deleted",
                    isSucces = true
                };
            }

            return new ResponseModel
            {
                Message = "User is maybe null",
                StatusCode = 400
            };
        }
    }
}
