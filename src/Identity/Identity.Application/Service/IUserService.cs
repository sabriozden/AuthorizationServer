using Identity.Domain.Entities;

namespace Identity.Application.Service
{
    public interface IUserService
    {

        public Task CreateAsync(ApplicationUser user);
    }
}
