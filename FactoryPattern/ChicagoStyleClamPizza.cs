using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            Name = "Chicago Style Clam Pizza";
            Dough = "Focaccia Dough";
            Sauce = "BBQ Sauce";

            toppings.Add("Parmesan Cheese");
        }
    }
}
