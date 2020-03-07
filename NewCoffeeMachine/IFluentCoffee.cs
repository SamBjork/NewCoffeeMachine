using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    interface IFluentCoffee
    {
        IFluentCoffee ChooseCupSize(CupSize cupSize);
        IFluentCoffee AddBeans(BeanSort beanSort, int amountIg);
        IFluentCoffee AddWater(int amountIcl);
        IFluentCoffee Heating(Func<int, bool> heatingWater);
        IFluentCoffee AddMilk(int amountIcl);
        IFluentCoffee AddMilkFoam(int amountImsk);
        IFluentCoffee AddChocolateSyrup(int amountIcl);

        CupJava ToBeverage();
    }
}
