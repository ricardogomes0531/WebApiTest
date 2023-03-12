using Microsoft.AspNetCore.Mvc;
using Src.Shared.Domain;
using Src.Shared.Repository.Interface;
using Src.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Src.Features.PostUser
{
    [ApiController]
    [Route("/api/v1/user")]
    public class UserController : ControllerBase
    {
        private readonly IPostUserUseCase _useCase;

        public UserController(IPostUserUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost]
        [ProducesResponseType(typeof(DataResult), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PostUserAsync(PostUserInput input)
        {
            var user = await _useCase.ExecuteAsync(new PostUserInput(input.Nome));
            if (user.IsValid)
                return Created("a", user);

            return BadRequest(user);



        }
    }
}
