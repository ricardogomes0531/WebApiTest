using Microsoft.AspNetCore.Mvc;
using Src.Shared.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Features.GetUserById
{
    [ApiController]
    [Route("/api/v1/user")]
        public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
                    }

        [HttpGet]
        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            return Ok(user);
               
        }
    }
}
