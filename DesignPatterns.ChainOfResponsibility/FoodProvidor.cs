using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class FoodProvidor : Handler
    {
        public FoodProvidor(Handler next) : base(next)
        {
        }

        private string DefineFoodType(Order order)
        {
            var foodType = order.FoodType;
            return foodType;
        }

        public void DefineFoodChief(Order order)
        {
            var foodType = DefineFoodType(order);
            Console.WriteLine("Providing your food");
            switch (foodType)
            {
                case "Pizza":
                    Console.WriteLine($"sending your order to your {foodType} Chief");
                    break;
                case "Pasta":
                    Console.WriteLine($"sending your order to your {foodType} chief");
                    break;
                case "Sea Food":
                    Console.WriteLine($"sending your order to your {foodType}chief");
                    break;
            }
        }

        public override bool doHandle(Order order)
        {
            DefineFoodChief(order);
            return false;
        }
    }
}
