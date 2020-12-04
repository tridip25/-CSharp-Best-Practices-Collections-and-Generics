using System;
using System.Collections.Generic;
namespace ex_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
          // Dictionary<string,string> states = new Dictionary<string,string>();

           //or 
            var states = new Dictionary<string,string>();
           states.Add("CA","California");
           states.Add("WA","Washington");

            Console.WriteLine("The keys are as follows:");
            foreach(var state in states.Keys)
            {
                Console.WriteLine(state);
            }

            Console.WriteLine("The values are as follows:");
            foreach(var state in states.Values)
            {
                Console.WriteLine(state);
            }


            //using the below syntax you can retrive the value just by providing the key......
            Console.WriteLine("\n\n"+states["CA"]);

            //So if you use the above syntax make sure to check whether the key exists or not......

            if(states.ContainsKey("CA"))
            {
                Console.WriteLine("\n\n"+states["CA"]);
            }

            //Or the other way could be using TryGetValue.......

            string st="";
            if(states.TryGetValue("CA", out st))
            {
                Console.WriteLine(st);
            }

        }
    }
}
