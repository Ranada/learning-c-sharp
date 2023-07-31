using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_145_AbstractClasses
{
    internal class Sphere : Shape
    {
        public int Radius { get; set; }

        public Sphere(int radius)
        { 
            Radius = radius;
            Name = "Sphere";
        }
        public override double Volume()
        {
            return (4/3) * Math.PI * Radius;
        }

        public override void GetInfo() 
        { 
            base.GetInfo();
            Console.WriteLine($"The volume of {Name} is {Volume()}");
        }
    }
}
