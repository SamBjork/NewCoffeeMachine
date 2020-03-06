using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    public class Espresso : IBeverageRecipe
    {
        public CupJava MakeBeverage()
        {
            CupJava espresso = new FluentCoffee()
                .AddBeans(BeanSort.Arabica, 5)
                .AddWater(300)
                .Heating(waterTemp => waterTemp > 90)
                .ToBeverage();
            Console.WriteLine("Your espresso is ready");

            return espresso;
        }
    }
}
