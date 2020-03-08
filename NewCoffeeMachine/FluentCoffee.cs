using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NewCoffeeMachine
{
    class FluentCoffee : IFluentCoffee
    {

        private CupJava cupjava { get; set; }
        private int temperature { get; set; }

        public FluentCoffee ()
        {
            cupjava = new CupJava();
            temperature = 89;
        }

        public IFluentCoffee ChooseCupSize(CupSize cupSize)
        {
            cupjava.CupType = cupSize.ToString();
            return this;
        }

        public IFluentCoffee AddBeans(BeanSort beanSort, int amountIg)
        {
            cupjava.Ingredients.Add("Beansort: " + beanSort.ToString() + ", " + amountIg + " grams");
            return this;
        }


        public IFluentCoffee AddWater(int amountIcl)
        {
            cupjava.Ingredients.Add("Water in milliliter: " + amountIcl);
            
            return this;
        }

        public IFluentCoffee Heating(Func<int,bool> heatingWater)
        {
            while (heatingWater.Invoke(temperature) == false)
            {
                Thread.Sleep(500);
                temperature++;
                Console.WriteLine("Heating water.. Current temperature: " + temperature + "°C");

            }
            Console.WriteLine("Heating done");
            Thread.Sleep(2000);
            Console.Clear();

                cupjava.Ingredients.Add("Temperature: " + temperature + "°C");

            return this;
        }
        public IFluentCoffee AddMilk(int amountIcl)
        {
            cupjava.Ingredients.Add("Milk in milliliter: " + amountIcl);
            return this;
        }

        public IFluentCoffee AddMilkFoam(int amountImsk)
        {
            cupjava.Ingredients.Add("Topped with " + amountImsk +" msk of Milk Foam");

            return this;
        }
        public IFluentCoffee AddChocolateSyrup(int amountIcl)
        {
            cupjava.Ingredients.Add("Added: " + amountIcl + "cl of Chocolate Syrup");

            return this;
        }

        public CupJava ToBeverage()
        {
            return cupjava;
        }
    }
}
