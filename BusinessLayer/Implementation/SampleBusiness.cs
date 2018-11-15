using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Implementation
{
    public class SampleBusiness : ISampleBusiness
    {
        public string TestBusinessMethod(string test)
        {
            return "This is from business.";
        }
    }
}
