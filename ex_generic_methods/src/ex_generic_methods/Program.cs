using System;

namespace ex_generic_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var generic_example =new genericMethod();
            generic_example.SwapValue<string>("apple","mango");
        }
    }
}
