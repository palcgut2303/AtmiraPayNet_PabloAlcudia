
using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.AccountDTO;

namespace AtmiraPayNet.Client.Services
{
    public interface IUserService
    {
        Task<UserListResult> UserList();
    }
}
