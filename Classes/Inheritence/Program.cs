namespace Inheritence;

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("Don't Make Me Think", 50, 50.00m, "Steve Krug");
        Book b2 = new Book("Richer, Wiser, Happier", 300, 99.99m, "William Green");
        Book b3 = new Book("Discipline Equals Freedom", 100, 999.99m, "Jocko Willink");

        Console.WriteLine("-----BOOKS-----");
        Console.WriteLine(b1.GetDescription());
        b1.Title = "(TEST) Set title using backing field";
        Console.WriteLine(b1.GetDescription());

        Console.WriteLine(b2.GetDescription());
        b2.Author = "(TEST) Set author using expression-bodied property";
        Console.WriteLine(b2.GetDescription());

        Console.WriteLine(b3.Description);

        b3.Price = 99.99m;
        Console.WriteLine($"Price: {b3.Price:C}");
        Console.WriteLine();

        Console.WriteLine("-----MAGAZINES-----");
        Magazine m1 = new Magazine("Surf Destinations", 5, 4.00m, "Surfer");
        Magazine m2 = new Magazine("Winter Escapes", 10, 10.00m, "Travel");
        Magazine m3 = new Magazine("Acient Egypt", 25, 14.99m, "National Geographic");

        m1.Publisher = "Inertia";
        m2.Price = 123.45m;
        m3.Title = "Pyramids of Giza";

        Console.WriteLine(m1.GetDescription());
        Console.WriteLine(m2.GetDescription());
        Console.WriteLine(m3.GetDescription());
        Console.WriteLine();

        Console.WriteLine("ToString overload example");                           
        Console.WriteLine(m1); // ToString can be implicitly called
        Console.WriteLine(m1.ToString("short")); 
        Console.WriteLine(m1.ToString("long")); 
    }
}
