using System;
using System.Collections.Generic;

namespace ex_listBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<String>(); 
            colors.Add("Red");
            colors.Add("Greed");

            foreach(var color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("------------------------------");
            //initializing while declaring(COLLECTION INITIALIZER)....

            var heros = new List<String>(){"Ram" , "Brad" , "Scott"};
            for(var i=0 ; i < heros.Count; i+=1)
            {
                Console.WriteLine(heros[i]);
            }
        }
    }
}
