using System;
using System.Collections.Generic;
namespace Автопарк
{
    public class Autopark
    {
        protected string name;
        protected List<PassengerCar> passenger_car = new List<PassengerCar>();
        protected List<Truck> trucks = new List<Truck>();

       

        public Autopark(string name, List<PassengerCar> passenger, List<Truck> trucks)
        {
            this.passenger_car = passenger;
            this.name = name;
            this.trucks = trucks;
        }


        public string PrintAll()
        {
            string str = "";
            for (int i = 0; i < passenger_car.Count; i++)
            {
                str += passenger_car[i].ToString();
                str += " ";
            }
            for (int j = 0; j < trucks.Count; j++)
            {
                str += trucks[j].ToString();
                str += " ";
            }
            return str;
        }
    }
}
