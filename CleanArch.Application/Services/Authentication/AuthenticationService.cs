namespace CleanArch.Application.Services.Authentication;

public interface IAuthenticationService
{

    AuthenticationResult Login (string firstname,string lastname,string email,string password);
    AuthenticationResult Register(string email,string password);
    
}