using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace OverrideEqualsHashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Model = "Privet";
            car.Color = "Black";
            Car car1 = new Car();
            car1.Model = "Privet";
            car1.Color = "Black";
            Console.WriteLine(car == car1);
            Console.WriteLine(car.Equals(car1));
            Console.ReadLine();

        }

    }

    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj as Car);
        }

        public bool Equals(Car other)
        {
            return other != null && Model == other.Model &&
                                    Color == other.Color;
        }

        public override int GetHashCode()
        {
            return this.Model.GetHashCode() ^ Color.GetHashCode();
        }
    }
}
