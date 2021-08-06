using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("Cheese"))
                return new NYStyleCheesePizza();
            else if (type.Equals("pepperoni"))
                return new NYStylePepperoniPizza();
            else if (type.Equals("clam"))
                return new NYStyleClamPizza();
            else
                return null;
        }
    }
}
