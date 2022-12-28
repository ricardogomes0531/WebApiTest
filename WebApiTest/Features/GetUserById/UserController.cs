using Microsoft.AspNetCore.Mvc;
using Src.Shared.Domain;
using Src.Shared.Repository.Interface;
using Src.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Src.Features.GetUserById
{
    [ApiController]
    [Route("/api/v1/user")]
        public class UserController : ControllerBase
    {
        private readonly IGetUserByIdUseCase _useCase;

        public UserController(IGetUserByIdUseCase useCase)
        {
            _useCase = useCase;
                    }

        [HttpGet]
                [ProducesResponseType(typeof(DataResult), (int)HttpStatusCode.OK)]
                [ProducesResponseType((int)HttpStatusCode.BadRequest)]
                        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            var user = await _useCase.ExecuteAsync(id);
            if (user.IsValid)
                return Ok(user);

            return BadRequest(user);
                
                            
               
        }
    }
}
