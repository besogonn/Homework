using System;
namespace Метро1
{
    public class Station
    {
        public Station()
        {
            string name;
            string colour;
            Line line;
            bool IsWeelchairAccessible;
            bool hasParkAndRide;
            bool hasNearbyCableCar;
            List<Station> transfers;
            

            public string Station(string name, string colour)
            {
                this.name = name;
                this.color = color;
            }

            public Station(string name, string color, List<Station> transfers)
            {
                this.name = name;
                this.color = color;
                this.transfers = new List<station>(); 

                
                foreach (Station i in transfers)
                {
                    this.transfers.Add(i);
                }

            }
            public string GetName()
            {
                return (name);
            }

            public string SetName(string name)
            {
                this.name = name;
            }

            public bool IsWheelchairAccesible()
            {
                return isWheelchairAccesible;
            }


            public bool HasParkAndRide()
            {
                return hasParkAndRide;
            }

            public bool HasNearbeCableCar()
            {
                return hasNearbyCableCar;
            }

            public string GetLineName()
            {
                return line.GetName();
            }
            public List<Station> GetTransfersList()
            {
                return transfers;
            }
        }
    }
}
