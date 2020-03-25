using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Order
    {
        //private string _userName;
        //private string _password;
        //private string _foodType;
        public Order( string userName , string password,string foodType)
        {
            UserName = userName;
            Password = password;
            FoodType = foodType;

        }

        public string FoodType { get; }
        public string UserName { get;  }

        public string Password { get; }
    }
}
