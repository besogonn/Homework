using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Метро1
{
    public class Line
    {
        public Line()
        {

            List<Station> stations;
            string name;
            string color;

            public string Line(string name, string colour)
            {
                this.name = name;
                this.color = color;
            }
            public string GetStation(string station)
            {
                return station;
            }
            public string GEtName()
            {
                return name;
            }
            public void SetName(string name)
            {
                this.name = name;
            }
            public string GetColour(string color)
            {

                return color;
            }

            public void SetColour()
            {
                this.color = color;
            }


            public void AddStation(string name, string color)
            {
                stations.Add(new Station(name, color));
            }

            public void RemoveStation(string name)
            {
                stations.Remove(new Station(name, color));
            }

            public Station GetStation(string name)
            {
                foreach (Station station in stations)
                {
                    if (station.GetName() == name)
                    {
                        return station;
                    }
                }
                return null;
            }
            public List<Station> GetStationList(string name)
            {
                return stations;
            }
        }
    }
}