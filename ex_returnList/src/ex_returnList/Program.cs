using System;
using System.Collections.Generic;
namespace ex_returnList
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new getList();
            var list = obj.GetTheList();
            
            foreach(var grade in list)
            {
                    Console.WriteLine(grade);
            }
            
        }
    }
}
