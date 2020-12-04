using System;
using System.Collections.Generic;


namespace ex_genericInterfacesLINQ
{
    public class WorkoutList
    {
        public IList<WorkOut> getData()
        {
            var works = new List<WorkOut>();
            works.Add(new WorkOut{type = "compound" , name = "squat" , reps = 3 , intervals = 50});
            works.Add(new WorkOut{type = "upper" , name = "bicep dumbell curl" , reps = 5 , intervals = 30});
            works.Add(new WorkOut{type = "upper" , name = "barbell curl" , reps = 3 , intervals = 30});
            works.Add(new WorkOut{type = "lower" , name = "calf raise" , reps = 3 , intervals = 40});
            works.Add(new WorkOut{type = "upper" , name = "Lats pull down" , reps = 5 , intervals = 50});
            works.Add(new WorkOut{type = "free" , name = "push up" , reps = 4 , intervals = 50});
            works.Add(new WorkOut{type = "free" , name = "parallel dips" , reps = 5 , intervals = 50});
            return works;
        } 
    }
}