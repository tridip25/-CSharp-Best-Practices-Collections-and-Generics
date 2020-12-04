using System;
using System.Linq;
using System.Collections.Generic;
namespace ex_genericInterfacesLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var workOut = new WorkoutList();
            var works = workOut.getData();

            var query = works.Where(v => v.type.Contains("free")).OrderBy(v => v.type);

           // var query =  from v in works where v.type.Contains("upper") orderby v.type select v; 


             var queryData = new List<WorkOut>();

            queryData = query.ToList();
          
            foreach(var item in queryData)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
