using Identity.Application.Domain.User.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ISender _sender;
        public UserController(ISender sender)
        {
            _sender = sender;

        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {

            await _sender.Send(new CreateUserCommand());

            return Ok();
        }
    }

}
