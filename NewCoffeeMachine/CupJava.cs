using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    public class CupJava
    {
        public List<string> Ingredients { get; }
        public string CupType { get; set; }

        public CupJava()
        {
            Ingredients = new List<string>();
        }

        internal void Print()
        {
            //Console.WriteLine("Cupsize: " + CupType.ToString());

            foreach (var item in Ingredients)
            {
                Console.WriteLine(item);
            }
        }
    }
}
