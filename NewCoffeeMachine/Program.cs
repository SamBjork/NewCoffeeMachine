using System;
using System.Collections.Generic;

namespace NewCoffeeMachine
{
    interface IBeverage
    {
        string Name { get; set; }

    }

    class Beverage : IBeverage
    {
        public string Name { get; set; }
    }
    class Ingredient
    {
        public string Name { get; set; }
        public int Amount { get; set; }

    }
    public class Water
    {
        public int Amount { get; set; }
        public int Temperature { get; set; }
    }
    
    // enum med cup-size

    public class Bean
    {
        public int AmountInG { get; set; }
        public BeanSorts Sort { get; set; }
    }

    public enum BeanSorts
    {
        Arabica,
        Columbia,
        Robusta
    }


    class Program
    {
        static void Main(string[] args)
        {

            IBeverage espresso = new FluentCoffee()
                .AddBeans(new Bean() { AmountInG = 5, Sort = BeanSorts.Arabica})
                .AddWater(new Water() { Amount = 20, Temperature = 90})
                .ToBeverage(new Beverage() { Name = "Espresso" });

        }
    }


    //public IBeverage AddMilk(bool gotMilk)
    //{
    //    ((List<Ingredient>)Ingredients).Add(new Ingredient() { Name = "Milk", gotMilk = true });
    //    return this;
    //}

    //public IBeverage AddWater(int amount)
    //{
    //    ((List<Ingredient>)Ingredients).Add(new Ingredient() { Name = "Water", amount = 30 });
    //    return this;
    //}

    //public IBeverage AddBeans(string type)
    //{
    //    ((List<Ingredient>)Ingredients).Add(new Ingredient() { Name = "Roast", type = "medium" });
    //    return this;
    //}

    //public void ToBeverage()
    //{
    //    foreach (var cp in Ingredients)
    //    {
    //        Console.WriteLine($"{Name} has {cp.gotMilk} {cp.Name} {cp.amount} {cp.type} {cp.size}");
    //    }
    //}


    //class Coffee : ICoffee 
    //{
    //    public ICoffee GotMilk();
    //    private IEnumerable<CoffeePart> CoffeParts {get; set; }
    //    private string Name {get; set; }

    //    public Coffee (string name)
    //    {
    //        CoffeParts = new List<CoffeePart>();
    //        Name = name;
    //    }

    //}

    //interface ICoffee
    //{
    //    ICoffee GotMilk();
    //    ICoffee Size(int number);
    //    ICoffee AddWater(int number);

    //}

    //class CoffeePart
    //{

    //}


    //class Beans
    //{
    //    string[] roast = { "ljus", "mellan", "mörk" };
    //    string[] country = { "Colombia", "Central America", "Arabica" };
    //    bool eko;
    //    string[] manufacturer = {"Gevalia", "Lövbergs Lila", "Starbucks" };

    //}
    //class Machine
    //{
    //    string sort;
    //    string bean;
    //    int temp;
    //    int[] water = {2,4,6};
    //    bool milk;

    //}
    //class Cup
    //{
    //    string[] size = { "small", "medium", "large" };
    //    string[] sort = { "latte", "espresso", "black", "cappucino" };

    //}
}
