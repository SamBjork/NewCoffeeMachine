using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    public class Mocha : IBeverageRecipe
    {
        public CupJava MakeBeverage(CupSize cupSize)
        {
            CupJava mocha = new FluentCoffee()
                .ChooseCupSize(cupSize)
                .AddBeans(BeanSort.Robusta, 6)
                .AddWater(15)
                .Heating(waterTemp => waterTemp >= 95)
                .AddChocolateSyrup(5)
                .AddMilk(20)
                .ToBeverage();
            Console.WriteLine("Your Mocha is ready!");
            Console.WriteLine();
            Console.WriteLine("You chose a " + cupSize.ToString() + " cup");
            Console.WriteLine("It was made with these ingredients: ");

            return mocha;
        }
    }
}
