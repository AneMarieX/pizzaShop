using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
   
        public abstract class AbstractPizzaDecorator : AbstractPizza
        {
        protected AbstractPizza pizza;
            public AbstractPizzaDecorator(AbstractPizza pizzaToDecorate)
            {
                this.pizza = pizzaToDecorate;
            }

            public override double GetPrice()
            {
                return (this.pizza.GetPrice() + this.myPrice);
            }
        }
}
    

