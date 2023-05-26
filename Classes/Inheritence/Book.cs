namespace Inheritence;

class Book : Publication
{
    string _author;

    public Book(string title, int pages, decimal price, string author)
     : base(title, pages, price) { 
        _author = author;
    }

    public override string GetDescription()
    {
        return $"{Title}, {Author}, pages {Pages}, {Price:C}";
    }
    public string Author
    {
        get => _author;
        set => _author = value;
    }
}