using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_145_AbstractClasses
{
    abstract class Shape
    {
        public string? Name { get; set; }
        
        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis a {Name}");
        }

        public abstract double Volume();
    }
}
