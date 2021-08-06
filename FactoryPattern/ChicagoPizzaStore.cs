using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("Cheese"))
                return new ChicagoStyleCheesePizza();
            else if (type.Equals("pepperoni"))
                return new ChicagoStylePepperoniPizza();
            else if (type.Equals("clam"))
                return new ChicagoStyleClamPizza();
            else
                return null;
        }
    }
}
