

using Microsoft.AspNetCore.Identity;

namespace Identity.Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {

        }
        public string? TcNo { get; set; }

    }


}