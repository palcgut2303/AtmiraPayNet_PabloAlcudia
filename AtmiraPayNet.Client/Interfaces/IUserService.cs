using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.AccountDTO;

namespace AtmiraPayNet.Client.Interfaces
{
    public interface IUserService
    {
        Task<UserListResult> UserList();
    }
}
