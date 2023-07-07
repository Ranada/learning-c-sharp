using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_130_VirtualOverrideDemo
{
    internal class Animal
    {
        private string _name;
        private int _age;
        private bool _isHungry;

        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public void MakeSound()
        {
            Console.WriteLine("Animal Sound!");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Play()
        {
            Console.WriteLine("Playing");
        }




    }
}
