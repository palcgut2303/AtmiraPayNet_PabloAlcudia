using Microsoft.AspNetCore.Identity;

namespace AtmitaPayNet.API.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }

        public DateTime _dateOfBirth { get; set; }
    }
}
