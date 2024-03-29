﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_130_VirtualOverrideDemo
{
    public class Animal
    {
        private string _name;
        private int _age;
        private bool _isHungry;

        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
            _isHungry = true;
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

        public bool IsHungry
        { 
            get => _isHungry;
            set => _isHungry = value;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Sound!");
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}
