using Identity.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Identity.Application.Domain.User.Commands
{

    public class CreateUserDto
    {

        public string? UserName { get; set; }
        public string? Password { get; set; }

    }

    public class CreateUserCommand : IRequest<int>
    {
        public CreateUserDto? Input { get; set; }
    }

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    //: ICommandRequestHandlerBase<CreateUserCommand, int>
    {

        private readonly UserManager<ApplicationUser> _userManager;
        public CreateUserCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }





        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new ApplicationUser
            {
                UserName = "sabri.ozden",
                Email = "sabriozden@live.com",
                TcNo = "30831052448",
                Id = Guid.NewGuid()


            };

            try
            {
                var result = await _userManager.CreateAsync(user);

                if (!result.Succeeded)
                {
                    Console.WriteLine(result.Errors);
                }

            }
            catch (System.Exception ex)
            {

                throw;
            }



            return 1;
        }


        // public async Task<BusinessRuleMessages<int>> Handle(ParameterDeleteCommand request, CancellationToken cancellationToken)
        // {
        //     return await _repoWrite.EfDelete(request.Input.Id, cancellationToken);
        // }


    }
}