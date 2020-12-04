using System;

namespace ex_returnDictionaryOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new getDictionary();
            var dict = obj.getDict();

            foreach(var dictValue in dict.Values)
            {
                Console.WriteLine(dictValue.ProductId + " " + dictValue.ProductPrice + " " + dictValue.ProductQuality);
            }
        }
    }
}
