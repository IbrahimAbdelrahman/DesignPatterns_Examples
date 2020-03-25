using System;

namespace DesignPatterns.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Authenticator -> Logger -> FoodProvidor
            var foodProvidor = new FoodProvidor(next:null);

            var logger = new Logger(foodProvidor);

            var authenticator = new Authenticator(logger);

            var restaurantServer = new Restaurant(authenticator);

            //restaurantServer.Handle(new Order("user", "1234", "Pasta"));
            // if input a wrong user it won't call the other handlers
            restaurantServer.Handle(new Order("-user", "1234", "Pasta"));
            Console.ReadLine();
        }
    }
}
