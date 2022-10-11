

using Microsoft.AspNetCore.Identity;

namespace Identity.Domain.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole()
        {

        }

        public Guid ClientId { get; set; }
    }
}