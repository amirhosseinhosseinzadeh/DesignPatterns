using static System.Console;
// using DesignPatterns.Facade.AuthenticationComponent;
// using DesignPatterns.Facade.AuthorizationComponent;
// using DesignPatterns.Facade.ValidationComponent;
using DesignPatterns.Facade;
using DesignPatterns.CreationalPatterns;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            string password = "";

            // without FACADE design pattern
            // ---------------------------------------------------------------------
            // var validationService = new ValidationService();
            // if(validationService.ISValidated(userName,password))
            // {
            //     var authenticationService = new AuthenticationService();
            //     if(authenticationService.IsAuthenticated(userName,password))
            //     {
            //         var authorizationService  = new AuthorizationService();
            //         if(authorizationService.IsAuthorized(userName,password))
            //             System.Console.WriteLine("User loged in !");
            //     }
            // }
            //------------------------------------------------------------------------

            //FACADE solution 
            var loginFacade = new LoginFacade();
            if(loginFacade.CanLogin(userName,password))
                System.Console.WriteLine("user loged in !");

            var firstCustomer = new Customer()
            {
                Name = "Alireza",
                LastName = "Mori",
                PhoneNumber = "+9890122222222"
            };
            var firstCustomerClone = firstCustomer.Clone();

            ReadLine();
        }
    }
}
