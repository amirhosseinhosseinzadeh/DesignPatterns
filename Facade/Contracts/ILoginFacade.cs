namespace DesignPatterns.Facade.Contracts
{
    public interface ILoginFacade
    {
        public bool CanLogin(string userName, string password);
    }
}