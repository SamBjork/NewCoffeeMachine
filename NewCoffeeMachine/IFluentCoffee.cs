using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    interface IFluentCoffee
    {
        IFluentCoffee AddBeans(BeanSort beanSort, int amountIg);
        IFluentCoffee AddMilk(int amountIml);
        IFluentCoffee AddWater(int amountIml);
        IFluentCoffee Heating(Func<int, bool> heatingWater);

        CupJava ToBeverage();
    }
}
