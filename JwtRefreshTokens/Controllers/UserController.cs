using JwtRefreshTokens.Services;
using Microsoft.AspNetCore.Mvc;

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
    }
}
