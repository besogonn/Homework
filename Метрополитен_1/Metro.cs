using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Метро1
{
    public class Metro
    {
        public Metro()
        {
            List<Line> lines;
            string city;
            public string Metro(string city)
            {
                this.city = city;
                lines = new List<Line>();
            }

            public string GetCity()
            {
                return city;
            }

            public void AddLine(string name, Color color)
            {
                Line line = new Line(name, color);
                lines.Add(line);
            }

            public void RemoveLine(string name)
            {
                foreach (Line j in lines)
                {
                    if (j.GetName() == name)
                    {
                        lines.Remove(j);
                    }
                }
            }

        }

    }
}
