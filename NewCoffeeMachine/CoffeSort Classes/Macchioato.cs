using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    public class Macchiato : IBeverageRecipe
    {
        public CupJava MakeBeverage(CupSize cupSize)
        {
            CupJava macchiato = new FluentCoffee()
                .ChooseCupSize(cupSize)
                .AddBeans(BeanSort.Robusta, 6)
                .AddWater(10)
                .Heating(waterTemp => waterTemp >= 95)
                .AddMilk(20)
                .AddMilkFoam(5)
                .ToBeverage();

            Console.WriteLine("Your Macchiato is ready!");
            Console.WriteLine();
            Console.WriteLine("You chose a " + cupSize.ToString() + " cup");
            Console.WriteLine("It was made with these ingredients: ");

            return macchiato;
        }
    }
}
