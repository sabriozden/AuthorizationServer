

using Microsoft.AspNetCore.Identity;

namespace Identity.Domain.Entities
{

    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
        public Guid ClientId { get; set; }
    }
}