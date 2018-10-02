using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
   
   
        public class HamDecorator : AbstractPizzaDecorator
        {
       
            public HamDecorator(PlainPizza pizzaToDecorate)
                : base(pizzaToDecorate)
            {
                this.myPrice = 1.49;
            }

        public HamDecorator(AbstractPizza pizzaToDecorate) : base(pizzaToDecorate)
        {
        }
    }
    
}
