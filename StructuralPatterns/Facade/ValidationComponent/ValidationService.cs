namespace DesignPatterns.Facade.ValidationComponent
{
    public class ValidationService : IValidationService
    {
        public bool ISValidated(string userName, string passwrod)
        {
            //validation logic
            return true;
        }
    }
}