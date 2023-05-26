namespace Defining;

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("Don't Make Me Think", "Steve Krug", 50);
        Book b2 = new Book("Richer, Wiser, Happier", "William Green", 300);
        Book b3 = new Book("Discipline Equals Freedom", "Jocko Willink", 100);

        Console.WriteLine(b1.GetDescription());
        b1.Title = "TEST - Updated Title";
        Console.WriteLine(b1.GetDescription());

    }
}
