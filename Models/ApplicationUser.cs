using Microsoft.AspNetCore.Identity;

namespace Contentor.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {

        }
        public ApplicationUser(string username) : base(username)
        {

        }

    }
}