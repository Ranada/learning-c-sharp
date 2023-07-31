namespace _10_145_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Cube(5));
            shapes.Add(new Sphere(100));
            
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"The {shape.Name} has a volume of {shape.Volume()}");
            }
        }
    }
}