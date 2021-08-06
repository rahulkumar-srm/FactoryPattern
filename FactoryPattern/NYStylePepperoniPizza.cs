using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            Name = "NY Style Pepperoni Pizza";
            Dough = "Stuffed Thin Crust Dough";
            Sauce = "Peppery Red Sauce";

            toppings.Add("Provolone Cheese");
        }
    }
}
