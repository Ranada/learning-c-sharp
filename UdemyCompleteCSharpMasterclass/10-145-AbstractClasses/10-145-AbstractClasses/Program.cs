﻿namespace _10_145_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new Cube(5);
            cube.GetInfo();

            Sphere sphere = new Sphere(100);
            sphere.GetInfo();
        }
    }
}