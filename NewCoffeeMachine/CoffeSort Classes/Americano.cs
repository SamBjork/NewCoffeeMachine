using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    public class Americano : IBeverageRecipe
    {
        public CupJava MakeBeverage(CupSize cupSize)
        {
            CupJava americano = new FluentCoffee()
                .ChooseCupSize(cupSize)
                .AddBeans(BeanSort.Robusta, 6)
                .AddWater(15)
                .Heating(waterTemp => waterTemp >= 95)
                .AddWater(15)
                .ToBeverage();

            Console.WriteLine("Your Americano is ready");
            Console.WriteLine();
            Console.WriteLine("You chose a " + cupSize.ToString() + " cup");
            Console.WriteLine("It was made with these ingredients: ");

            return americano;
        }
    }
}
