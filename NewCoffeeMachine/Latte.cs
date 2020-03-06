using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    public class Latte : IBeverageRecipe
    {
        public CupJava MakeBeverage()
        {
            CupJava latte = new FluentCoffee()
               .AddBeans(BeanSort.Robusta, 10)
               .AddWater(200)
               .Heating(waterTemp => waterTemp > 96)
               .ToBeverage();
            Console.WriteLine("Your latte is ready");

            return latte;
        }
    }
}
