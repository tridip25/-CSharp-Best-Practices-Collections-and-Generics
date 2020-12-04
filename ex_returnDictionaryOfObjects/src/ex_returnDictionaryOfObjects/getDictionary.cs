using System;
using System.Collections.Generic;

namespace ex_returnDictionaryOfObjects
{
    public class getDictionary
    {
        public Dictionary<int,product> getDict()
        {
            var dict = new Dictionary<int, product>();
            dict.Add(121,new product(){ProductId = 121, ProductQuality = "Okay" , ProductPrice = 855});
            dict.Add(122,new product(){ProductId = 122, ProductQuality = "Good" , ProductPrice = 676});
            return dict;
        }
    }
}