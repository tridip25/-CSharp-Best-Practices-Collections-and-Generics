using System;

namespace ex_generic2_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new generic_multiple<string,string>("hello","hi");
            Console.WriteLine(obj.Value+" "+obj.Result);

            var obj1 = new generic_multiple<decimal,decimal>(100,101);
            Console.WriteLine(obj1.Value+" "+obj1.Result);

        }
    }
}
