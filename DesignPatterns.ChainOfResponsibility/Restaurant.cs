using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    //act as your web server start up configuration
    public class Restaurant
    {
        private Handler _handler;
        public Restaurant(Handler handler)
        {
            this._handler = handler;
        }
        public void Handle(Order order)
        {
            _handler.Handle(order);
           
            //Authentication
            // you make a tightly couble responsibilty between your server and your class
            // bad approach becouse it violate open/close principle 
            //var authenticator = new Authenticator();
            //authenticator.Authenticate(order);
            //Logging
            //Define type of order
        }
    }
}
