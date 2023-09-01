using BookstoreApp.Blazor.Server.UI.HttpServices.Base;

namespace BookstoreApp.Blazor.Server.UI.HttpServices.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
    }

}
