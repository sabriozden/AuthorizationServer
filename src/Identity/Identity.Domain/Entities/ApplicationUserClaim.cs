

using Microsoft.AspNetCore.Identity;

namespace Identity.Domain.Entities
{
    public class ApplicationUserClaim : IdentityUserClaim<Guid>
    {
        public Guid ClientId { get; set; }
    }

}