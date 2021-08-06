using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryPattern
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
{
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thik Crust Dough";
            Sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }
    }
}
