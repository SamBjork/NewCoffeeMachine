using System;
using System.Collections.Generic;
using System.Text;

namespace NewCoffeeMachine
{
    public interface IBeverageRecipe
    {
        CupJava MakeBeverage();
    }
}
