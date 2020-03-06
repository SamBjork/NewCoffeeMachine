using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    interface IFluentCoffee
    {
        IFluentCoffee ChooseCupSize(CupSize cupSize);
        IFluentCoffee AddBeans(BeanSort beanSort, int amountIg);
        IFluentCoffee AddMilk(int amountIcl);
        IFluentCoffee AddWater(int amountIcl);
        IFluentCoffee Heating(Func<int, bool> heatingWater);

        CupJava ToBeverage();
    }
}
