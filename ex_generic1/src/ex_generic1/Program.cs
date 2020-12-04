using System;

namespace ex_generic1
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new generic<string>("hello","thank you");
            Console.WriteLine(obj.Result+" "+obj.Message);
            var obj1 = new generic<decimal>(98,"thank you");
            Console.WriteLine(obj1.Result+" "+obj1.Message);

        }
    }
}
