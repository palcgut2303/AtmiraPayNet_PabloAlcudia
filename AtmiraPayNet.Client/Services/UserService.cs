
using AtmiraPayNet.Shared;
using System.Net.Http.Json;
using System.Text;

namespace AtmiraPayNet.Client.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public async Task<UserListResult> UserList()
        {
            var result = await _http.GetFromJsonAsync<UserListResult>("api/User");

            return result;

        }

    }
}
