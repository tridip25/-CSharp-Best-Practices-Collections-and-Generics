using System;
using System.Collections.Generic;

namespace ex_returnList
{
    public class getList
    {
        public List<string> GetTheList()
        {
            var grades = new List<string>(){"Outstanding","Very Good","Good", "Average" ,"Pass" , "Fail"};
            return grades;
        }
    }
}