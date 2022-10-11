

using Microsoft.AspNetCore.Identity;

namespace Identity.Domain.Entities
{

    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
        public Guid ClientId { get; set; }
    }

}