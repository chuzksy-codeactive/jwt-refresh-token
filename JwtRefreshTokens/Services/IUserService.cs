using JwtRefreshTokens.Models;
using System.Threading.Tasks;

namespace JwtRefreshTokens.Services
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModel model);
    }
}
