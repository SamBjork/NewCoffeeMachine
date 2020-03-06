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
            }

            return null;
        }
    }
}
