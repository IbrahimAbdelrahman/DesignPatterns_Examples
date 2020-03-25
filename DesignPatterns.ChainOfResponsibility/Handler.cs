using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    
    public abstract class Handler
    {
        //each handler should maintain a reference to the next handler in the chain
        private Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }
        //template for handle your request
        public void Handle( Order order)
        {
            if (doHandle(order))
                return;
            if (_next != null)
            {
                _next.Handle(order);
            }
        }

        //declare your handle method and should be abstract, cause at this time you don't know
        //how to handle a request, and that's something you will handle in your concrete handler class
        public abstract bool doHandle(Order order);
    }
}
