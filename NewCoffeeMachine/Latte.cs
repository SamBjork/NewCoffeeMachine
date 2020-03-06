using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    public class Latte : IBeverageRecipe
    {
        public CupJava MakeBeverage(CupSize cupSize)
        {
            CupJava latte = new FluentCoffee()
                .ChooseCupSize(cupSize)
                .AddBeans(BeanSort.Robusta, 6)
                .AddWater(10)
                .AddMilk(20)
                .Heating(waterTemp => waterTemp >= 95)
                .ToBeverage();
            Console.WriteLine("Your latte is ready");

            return latte;
        }
    }
}
