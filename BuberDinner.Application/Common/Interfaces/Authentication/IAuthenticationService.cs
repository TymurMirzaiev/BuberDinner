using BuberDinner.Application.Services.Authentication;
using ErrorOr;

namespace BuberDinner.Application.Common.Interfaces.Authentication;

public interface IAuthenticationService
{
    ErrorOr<AuthenticationResult> Login(string email, string password);
    ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
}
