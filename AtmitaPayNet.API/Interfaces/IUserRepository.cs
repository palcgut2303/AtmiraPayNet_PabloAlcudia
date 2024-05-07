namespace AtmitaPayNet.API.Interfaces
{
    public interface IUserRepository
    {
        Task<string> GetUserIdByEmailAsync(string email);
        Task<List<string>> GetUserRolesAsync(string userId);
    }
}
