namespace Defining;

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("Don't Make Me Think", "Steve Krug", 50);
        Book b2 = new Book("Richer, Wiser, Happier", "William Green", 300);
        Book b3 = new Book("Discipline Equals Freedom", "Jocko Willink", 100);

        Console.WriteLine(b1.GetDescription());
        b1.Title = "(TEST) Set title using backing field";
        Console.WriteLine(b1.GetDescription());

        Console.WriteLine(b2.GetDescription());
        b2.Author = "(TEST) Set author using expression-bodied property";
        Console.WriteLine(b2.GetDescription());

        Console.WriteLine(b3.Description);

    }
}
