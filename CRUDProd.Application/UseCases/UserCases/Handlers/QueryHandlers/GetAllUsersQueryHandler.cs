using CRUDProd.Application.Abstraction;
using CRUDProd.Application.UseCases.UserCases.Queries;
using CRUDProd.Domain.Entities.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProd.Application.UseCases.UserCases.Handlers.QueryHandlers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private readonly IUserDbContext _context;
        private readonly IMediator _mediator;
        public GetAllUsersQueryHandler(IUserDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        async Task<List<User>> IRequestHandler<GetAllUsersQuery, List<User>>.Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }
    }
}
