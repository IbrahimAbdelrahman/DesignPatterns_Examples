using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Logger: Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool doHandle(Order order)
        {
            Console.WriteLine("Log");

            // to call the next handler in the chain
            return false;
        }

       
    }
}
