using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
   
        public  class BaconDecorator: AbstractPizzaDecorator
        {
   
            public BaconDecorator(HamDecorator pizzaToDecorate)
                : base(pizzaToDecorate)
            {
                this.myPrice = 0.99;
            }
        }
    
    
}
