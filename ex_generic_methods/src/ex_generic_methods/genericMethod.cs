using System;

namespace ex_generic_methods
{
    public class genericMethod
    {
       public void SwapValue<TSwap>(TSwap a, TSwap b)
       {
           TSwap m;
           m = a;
           a = b;
           b = m;
           Console.WriteLine($"Value of a: {a}");
           Console.WriteLine($"Value of b: {b}");
       }
    }
}