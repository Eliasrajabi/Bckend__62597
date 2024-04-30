
using backend.Models;

namespace backend.Controllers.Interfaces
{
    public interface IJWT_TokenService
    {
        string GenerateJwtToken(User user);
    }
}