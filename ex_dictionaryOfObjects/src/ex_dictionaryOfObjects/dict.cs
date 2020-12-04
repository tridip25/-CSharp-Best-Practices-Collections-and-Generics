using System;
using System.Collections.Generic;

namespace ex_dictionaryOfObjects
{
    public class dict
    {
        public void AddVendors()
        {
        Dictionary<string,vendors> vendors = new Dictionary<string,vendors>();
        vendors.Add("technomate", new vendors(){VendorId = 122, CompanyName = "technomate" , Email = "abc@abc.com"});
        vendors.Add("Edubotics", new vendors(){VendorId = 123, CompanyName = "Edubotics" , Email = "def@def.com"});

       // Console.WriteLine(vendors["technomate"].VendorId);

        foreach(var vendor in vendors.Values)
        {
          Console.WriteLine(vendor.VendorId);
          Console.WriteLine(vendor.CompanyName);
          Console.WriteLine(vendor.Email);
        }
        
        }
    }
}