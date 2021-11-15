using System;
using System.Collections.Generic;
namespace Автопарк
{
    public class Truck : Car
    {
        protected int maxweight;
        protected string nameofdriver;
        Dictionary<string, int> book = new Dictionary<string, int>();
        public Truck(string brand, int year, int power, int max, string name) : base(brand, year, power)
        {
            this.maxweight = max;
            this.nameofdriver = name;
        }
        public override string ToString()
        {
            return brand + " " + power + " " + year + " " + maxweight + " " + nameofdriver; ;
        }


    }
}
