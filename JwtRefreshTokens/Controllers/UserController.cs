using JwtRefreshTokens.Models;
using JwtRefreshTokens.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JwtRefreshTokens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(RegisterModel model)
        {
            var result = await _userService.RegisterAsync(model);

            return Ok(result);
        }
    }
}
