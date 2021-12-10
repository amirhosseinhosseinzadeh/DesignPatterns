using DesignPatterns.Facade.Contracts;
using DesignPatterns.Facade.AuthorizationComponent;
using DesignPatterns.Facade.AuthenticationComponent;
using DesignPatterns.Facade.ValidationComponent;

namespace DesignPatterns.Facade
{
    public class LoginFacade : ILoginFacade
    {
        private readonly IValidationService _validationService;
        private readonly IAuthorizationService _authorizationService;
        private readonly IAuthenticationService _authenticationService;

        public LoginFacade()
        {
            _authenticationService = new AuthenticationService();
            _authorizationService = new AuthorizationService();
            _validationService = new ValidationService();
        }

        public bool CanLogin(string userName, string password)
            => (_validationService.ISValidated(userName, password) &&
                    _authenticationService.IsAuthenticated(userName, password) &&
                    _authorizationService.IsAuthorized(userName, password));
    }
}