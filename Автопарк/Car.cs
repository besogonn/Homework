using System;
namespace Автопарк
{
    public class Car
    {
        protected string brand;
        protected int year;
        protected int power;

        public Car(string brand, int year, int power)
        {
            this.brand = brand;
            this.year = year;
            this.power = power;
        }
        public virtual string Tostring()
        {
            return brand + " " + year + " " + power;
        }
        
    }
}
