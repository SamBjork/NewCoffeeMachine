using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    public class BeverageRecipeFactory
    {
        public IBeverageRecipe getRecipe(CoffeeSort coffeeSort)
        {
            switch (coffeeSort)
            {
                case CoffeeSort.Latte: return new Latte();

                case CoffeeSort.Espresso: return new Espresso();

                case CoffeeSort.Americano: return new Americano();

                case CoffeeSort.Macchiato: return new Macchiato();

                case CoffeeSort.Cappucino: return new Cappuccino();

                case CoffeeSort.Mocha: return new Mocha();
            }

            return null;
        }
    }
}
