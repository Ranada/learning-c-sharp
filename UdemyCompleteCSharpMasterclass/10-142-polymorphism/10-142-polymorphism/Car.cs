using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_142_polymorphism
{
    public class Car
    {
        public string HP { get; set; }
        public string Color { get; set; }

        public Car(string hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"{HP} horsepower, {Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
