namespace Inheritence;

class Publication
{
    private string _title;
    private int _pages;
    private decimal _price;

    public Publication(string title, int pages, decimal price)
    {
        // Access default is Private
        _title = title;
        _pages = pages;
        _price = price;
    }

    public virtual string GetDescription()
    {
        return $"{Title}, {Pages} pages, {Price}";
    }

    // TODO: Shorthand way of writing the above using the => operator to create "expression-bodied" properties
    public string Title
    {
        get => _title;
        set => _title = value;
    }
    public int Pages
    {
        get => _pages;
        set => _pages = value;
    }

    public decimal Price
    {
        get => _price;
        set => _price = value;
    }

    public string Description
    {
        get => $"{Title}, {Pages} pages";
    }
}