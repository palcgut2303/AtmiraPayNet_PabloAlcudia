using AtmitaPayNet.API.Models;

namespace AtmitaPayNet.API.Service
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
