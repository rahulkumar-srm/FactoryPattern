using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            Name = "NY Style Clam Pizza";
            Dough = "Stuffed Thick Crust Dough";
            Sauce = "Creamy Alfredo Sauce";

            toppings.Add("Mozzarella Cheese");
        }
    }
}
