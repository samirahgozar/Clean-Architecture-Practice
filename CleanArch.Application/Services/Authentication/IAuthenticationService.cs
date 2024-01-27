namespace CleanArch.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    AuthenticationResult IAuthenticationService.Login(string firstname, string lastname, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), firstname, lastname, email, "token");
    }

    AuthenticationResult IAuthenticationService.Register(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(),"firstname", "lastname", email, "token");
    }
}
