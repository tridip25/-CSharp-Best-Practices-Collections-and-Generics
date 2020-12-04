using System;

namespace ex_retuenListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
           var obj = new exampleReturn();
           var grades = obj.getList();
           foreach(var grade in grades)
           {
                Console.WriteLine(grade.ProductId +" "+ grade.ProductPrice +" "+ grade.ProductQuality);
           }
        }
    }
}
