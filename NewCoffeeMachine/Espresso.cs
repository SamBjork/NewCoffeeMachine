using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    public class Espresso : IBeverageRecipe
    {
        public CupJava MakeBeverage(CupSize cupSize)
        {
            CupJava espresso = new FluentCoffee()
                .ChooseCupSize(cupSize)
                .AddBeans(BeanSort.Arabica, 5)
                .AddWater(20)
                .Heating(waterTemp => waterTemp >= 95)
                .ToBeverage();
            Console.WriteLine("Your espresso is ready");

            return espresso;
        }
    }
}
