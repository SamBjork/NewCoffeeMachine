using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    class FluentCoffee : IFluentCoffee
    {
        public Water _water { get; set; }
        public Bean _bean { get; set; }

        public bool _milk; 
        public Beverage _beverage { get; set; }


        public IFluentCoffee AddBeans(Bean bean)
        {
            _bean = bean;
            return this;
        }

        public IFluentCoffee AddMilk()
        {
            _milk = true;
            return this;
        }

        public IFluentCoffee AddWater(Water water)
        {
            _water = water;
            return this;
        }

        public IBeverage ToBeverage(Beverage beverage)
        {
            if (_milk == true)
                _beverage.Name = "Latte";

            else
                _beverage.Name = "Espresso";

            Console.WriteLine("Välkommen till kaffemaskinen");
            Console.WriteLine("");
            Console.WriteLine("Du har gjort en: " + _beverage.Name);
            Console.ReadLine();

            //throw new NotImplementedException();
            return _beverage;
        }
    }

    interface IFluentCoffee
    {
        IFluentCoffee AddWater(Water water);

        IFluentCoffee AddBeans(Bean bean);

        IBeverage ToBeverage(Beverage beverage);

    }
}
