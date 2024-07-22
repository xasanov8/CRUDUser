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
    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, User>
    {
        private readonly IUserDbContext _context;
        private readonly IMediator _mediator;
        public GetByIdUserQueryHandler(IUserDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<User> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id);

            return user;
        }
    }
}
