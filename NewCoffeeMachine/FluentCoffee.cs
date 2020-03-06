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
            temperature = 86;
        }

        public IFluentCoffee ChooseCupSize(CupSize cupSize)
        {
            cupjava.CupType = cupSize.ToString();
            return this;
        }

        public IFluentCoffee AddBeans(BeanSort beanSort, int amountIg)
        {
            cupjava.Ingredients.Add("Beansort: " + beanSort.ToString() + " Amount in grams: " + amountIg);
            return this;
        }

        public IFluentCoffee AddMilk(int amountIcl)
        {
            cupjava.Ingredients.Add("Milk in milliliter: " + amountIcl);
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
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();

                cupjava.Ingredients.Add("Water temperature: " + temperature);

            return this;
        }

        public CupJava ToBeverage()
        {
            return cupjava;
        }
    }
}
