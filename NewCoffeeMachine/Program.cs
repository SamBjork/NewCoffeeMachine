using System;
using System.Collections.Generic;

namespace NewCoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageRecipeFactory beverageRecipeFactory = new BeverageRecipeFactory();
            IBeverageRecipe beverageRecipe = null;

            Console.WriteLine("Välkommen till grupp 7's kaffemaskin");
            Console.WriteLine("Vänligen välj kaffe!");
            Console.WriteLine("(1): Espresso (2): Latte (3): Americano (4): Macchiato (5): Mocha (6): Latte");

            var key = Console.ReadKey();
            Console.Clear();

            if (key.KeyChar == '1')
            {
                beverageRecipe = beverageRecipeFactory.getRecipe(CoffeeSort.Espresso);

            }
            else if (key.KeyChar == '2')
            {
                beverageRecipe = beverageRecipeFactory.getRecipe(CoffeeSort.Latte);

            }
            else
            {
                throw new Exception("Fel val");
            }

            Console.WriteLine("Vänligen välj storlek på koppen");
            Console.WriteLine("(1): Small (2): Meduim (3): Large");

            var nextKey = Console.ReadKey();
            Console.Clear();

            if (nextKey.KeyChar == '1')
            {
                beverageRecipe.MakeBeverage(CupSize.Small).Print();
            }
            else if (nextKey.KeyChar == '2')
            {
                beverageRecipe.MakeBeverage(CupSize.Medium).Print();
            }
            else if (nextKey.KeyChar == '3')
            {
                beverageRecipe.MakeBeverage(CupSize.Large).Print();
            }



        }
    }
}
