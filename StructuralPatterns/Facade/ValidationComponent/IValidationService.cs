namespace DesignPatterns.Facade.ValidationComponent
{
    public interface IValidationService
    {
        bool ISValidated(string userName,string passwrod);
    }
}