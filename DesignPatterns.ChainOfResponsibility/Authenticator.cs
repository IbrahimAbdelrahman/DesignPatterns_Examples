using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Authenticator: Handler
    {
        //public bool Authenticate(Order order)
        //{

        //}
        public Authenticator(Handler next):base(next)
        {
            
        }

        public override bool doHandle(Order order)
        {
            var isValid = (order.UserName == "user" && order.Password == "1234");
            Console.WriteLine("Authentication");

            // to call the next handler
            return !isValid;
        }
    }
}
