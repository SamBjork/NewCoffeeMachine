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

            Console.WriteLine("Welcome to the coffeemachine!");
            Console.WriteLine("Please choose coffee to make!");
            Console.WriteLine("(1): Espresso (2): Latte (3): Americano (4): Macchiato (5): Mocha (6): Cappuccino");

            var key = Console.ReadKey();
            Console.Clear();

            if (key.KeyChar == '1')
                beverageRecipe = beverageRecipeFactory.getRecipe(CoffeeSort.Espresso);

            else if (key.KeyChar == '2')
                beverageRecipe = beverageRecipeFactory.getRecipe(CoffeeSort.Latte);

            else if (key.KeyChar == '3')
                beverageRecipe = beverageRecipeFactory.getRecipe(CoffeeSort.Americano);

            else if (key.KeyChar == '4')
                beverageRecipe = beverageRecipeFactory.getRecipe(CoffeeSort.Macchiato);

            else if (key.KeyChar == '5')
                beverageRecipe = beverageRecipeFactory.getRecipe(CoffeeSort.Mocha);

            else if (key.KeyChar == '6')
                beverageRecipe = beverageRecipeFactory.getRecipe(CoffeeSort.Cappucino);

            else
                throw new Exception("Fel val");

            Console.WriteLine("Please choose cupsize!");
            Console.WriteLine("(1): Small (2): Meduim (3): Large");

            var nextKey = Console.ReadKey();
            Console.Clear();

            if (nextKey.KeyChar == '1')
            {
                beverageRecipe.MakeBeverage(CupSize.small).Print();
            }
            else if (nextKey.KeyChar == '2')
            {
                beverageRecipe.MakeBeverage(CupSize.medium).Print();
            }
            else if (nextKey.KeyChar == '3')
            {
                beverageRecipe.MakeBeverage(CupSize.large).Print();
            }
        }
    }
}
