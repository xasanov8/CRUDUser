using CRUDProd.Application.Abstraction;
using CRUDProd.Application.UseCases.UserCases.Commands;
using CRUDProd.Application.UseCases.UserCases.Queries;
using CRUDProd.Domain.Entities.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDProd.Api.Controllers.UserControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserDbContext _context;
        private readonly IMediator _mediator;

        public UsersController(IUserDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<User>> GetByIdUser(GetByIdUserQuery command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(UpdateUserCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(DeleteUserCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
