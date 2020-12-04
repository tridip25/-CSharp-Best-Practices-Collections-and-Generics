using System;

namespace ex_generic2_multiple
{
    public class generic_multiple<Tvalue,Tresult>
    {
        public generic_multiple(Tvalue value , Tresult result)
        {
            this.Value = value;
            this.Result = result;
        }

        public Tvalue Value{get;set;}
        public Tresult Result{get;set;}
    }
}