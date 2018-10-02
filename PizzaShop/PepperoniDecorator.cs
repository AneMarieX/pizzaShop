using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
   
        public class PepperoniDecorator : AbstractPizzaDecorator
        {
      
            public PepperoniDecorator(PlainPizza pizzaToDecorate)
                : base(pizzaToDecorate)
            {
                this.myPrice = 1.49;
            }

        public PepperoniDecorator(AbstractPizza pizzaToDecorate) : base(pizzaToDecorate)
        {
        }
    }

    
}
