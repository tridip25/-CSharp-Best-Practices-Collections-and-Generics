using System;
using System.Collections.Generic;

namespace ex_listOfObjects
{
    class mediator
    {

        public void AddDisplayVendors()
        {
            var vendors = new List<vendor>();

            vendors.Add(new vendor(){id = 23 , companyName = "cts" , email = "abc@abc.com"});
            
              foreach(var vendor in vendors)
            {
                Console.WriteLine(vendor.id +" "+ vendor.companyName +" "+ vendor.email);
            }
        }

        
    }
}
