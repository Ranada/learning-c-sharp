using BookstoreApp.Blazor.Server.UI.HttpServices.Base;

namespace BookstoreApp.Blazor.Server.UI.HttpServices.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IClient httpClient;

        public AuthenticationService(IClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task<bool> AuthenticateAsync(LoginUserDto loginModel)
        {
            throw new NotImplementedException();
        }
    }

}
