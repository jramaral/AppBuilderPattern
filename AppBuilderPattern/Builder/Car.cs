using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBuilderPattern.Builder
{
    public  class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Color: {Color}";
        }
    }
}
