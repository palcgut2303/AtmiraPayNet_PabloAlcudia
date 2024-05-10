using AtmiraPayNet.Shared.AccountDTO;

namespace AtmiraPayNet.Client.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginDTO loginModel);
        Task<RegisterResult> Register(RegisterDTO registerModel);
    }
}
