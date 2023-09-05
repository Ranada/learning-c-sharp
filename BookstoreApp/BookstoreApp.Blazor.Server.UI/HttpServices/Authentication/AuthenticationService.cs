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
        public async Task<bool> AuthenticateAsync(LoginUserDto loginModel)
        {
            var response = await httpClient.LoginAsync(loginModel);

            // Store token


            // Change auth state of app


            return true;
        }
    }

}
