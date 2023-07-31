using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_142_polymorphism
{
    public class BMW : Car
    {
        private string Brand = "BMW";
        public string Model { get; set; }
        public BMW(string HP, string Color, string model) : base(HP, Color) 
        {
            Model = model;
        }
        
        public override void ShowDetails()
        {
            Console.WriteLine($"{Brand} {Model}, {HP} horsepower, {Color}");
        }

        public override void Repair()
        {
            Console.WriteLine($"{Brand} {Model} was repaired!");
        }
    }
}
