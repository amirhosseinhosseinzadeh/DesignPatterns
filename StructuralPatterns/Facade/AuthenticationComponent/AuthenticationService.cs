namespace DesignPatterns.Facade.AuthenticationComponent
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool IsAuthenticated(string userName, string password)
        {
            //authentication logic ...
            return true;
        }
    }
}