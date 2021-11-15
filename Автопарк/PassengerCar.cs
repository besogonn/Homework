using System;
using System.Collections.Generic;
namespace Автопарк
{
    public class PassengerCar : Car
    {
        private int NumberOfPassengers;
        Dictionary<string, int> repairbook = new Dictionary<string, int>(); 
        
        public PassengerCar(string brand, int year, int power, int Num) : base(brand, year, power)
        {
            this.NumberOfPassengers = Num;
        }
        public void AddParts(string detal, int data)
        {
            repairbook.Add(detal, data);
        }
        public int GetYearOfReplacement(string detal)
        {

            if (repairbook.ContainsKey(detal))
                return repairbook[detal];
            return 0;

        }
        public void EraseAllRepairbook()
        {
            var keys = repairbook.Keys;
            foreach (var item in keys)
            {
                repairbook.Remove(item);
            }
        }
        public void printrepairbook()
        {
            var keys = repairbook.Keys;
            foreach (var item in repairbook.Keys)
            {
                Console.Write(item + " - ");
                Console.Write(repairbook[item]);
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return brand + " " + power + " " + year + " " + NumberOfPassengers;

        }
    }
}
