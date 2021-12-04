namespace DesignPatterns.Facade.AuthenticationComponent
{
    public interface IAuthenticationService
    {
        public bool IsAuthenticated(string userName, string password);
    }
}