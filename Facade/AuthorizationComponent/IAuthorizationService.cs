namespace DesignPatterns.Facade.AuthorizationComponent
{
    public interface IAuthorizationService
    {
        public bool IsAuthorized(string userName, string password);
    }
    public class AuthorizationService : IAuthorizationService
    {
        public bool IsAuthorized(string userName, string password)
        {
            //authorization logic ...
            return true;    
        }
    }
}