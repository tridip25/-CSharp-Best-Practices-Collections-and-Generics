using System;
using System.Collections.Generic;

namespace ex_retuenListOfObjects
{
    public class exampleReturn
    {
        public List<product> getList()
        {
            var grades = new List<product>();
            grades.Add(new product(){ProductId = 121 , ProductPrice = 999 ,ProductQuality = "Good"});
            return grades;

        }
    }
}