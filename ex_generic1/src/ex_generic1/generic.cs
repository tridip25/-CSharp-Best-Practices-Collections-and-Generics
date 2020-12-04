using System;

namespace ex_generic1
{
    public class generic<T>
    {
        public generic(T result , string message)
        {
            this.Result = result;
            this.Message = message;
        }
        public T Result{get;set;}
        public string Message{get;set;}
    }
}