using AtmitaPayNet.API.Contexto;
using AtmitaPayNet.API.Interfaces;
using AtmitaPayNet.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AtmitaPayNet.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _contextDb;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRepository(ApplicationDbContext dbContext, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this._contextDb = dbContext;
            this._userManager = userManager;
            this._roleManager = roleManager;


        }

        public async Task<List<string>> GetUserRolesAsync(string userId)
        {
            var user = await _contextDb.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user != null)
            {
                var roles = await _userManager.GetRolesAsync(user);
                return roles.ToList();
            }
            return new List<string>(); // O devuelve una lista vacía u otro valor predeterminado si el usuario no se encuentra
        }


        public async Task<string> GetUserIdByEmailAsync(string email)
        {
            var user = await _contextDb.Users.FirstOrDefaultAsync(u => u.Email == email);
            return user?.Id;
        }
    }
}
