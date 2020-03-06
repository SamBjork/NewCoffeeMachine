using System;
using Xunit;
using NewCoffeeMachine;
using System.IO;
using System.Diagnostics;

namespace BeverageTest
{
    public class ToDebugWriter : StringWriter
    {
        public override void WriteLine(string value)
        {
            Debug.WriteLine(value);
            base.WriteLine(value);
        }
    }

    public class BeverageTests
    {

        public BeverageTests ()
        {
            Console.SetOut(new ToDebugWriter());
        }

        [Fact]
        public void MakeEspresso()
        {
            BeverageRecipeFactory beverageRecipeFactory = new BeverageRecipeFactory();
            IBeverageRecipe recipe = beverageRecipeFactory.getRecipe(CoffeeSort.Espresso);

            var cupjava = recipe.MakeBeverage();

            Assert.Equal("Beansort: Arabica Amount in grams: 5", cupjava.Ingredients[0]);
        }

        [Fact]
        public void MakeLatte()
        {
            IBeverageRecipe latte = new Latte();

        }
    }
}
