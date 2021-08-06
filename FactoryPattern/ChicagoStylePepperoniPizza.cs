using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            Name = "Chicago Style Pepperoni Pizza";
            Dough = "Flat Bread Dough";
            Sauce = "Sweet Pizza Sauce";

            toppings.Add("Cheddar Cheese");
        }
    }
}
