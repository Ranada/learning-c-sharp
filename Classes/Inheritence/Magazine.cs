namespace Inheritence;

class Magazine : Publication
{
    string _publisher;

    public Magazine(string title, int pages, decimal price, string publisher)
     : base(title, pages, price) { 
        _publisher = publisher;
    }

    public override string GetDescription()
    {
        return $"{Title}, Publisher: {Publisher}, {Pages} pages, {Price:C}";
    }
    public string Publisher
    {
        get => _publisher;
        set => _publisher = value;
    }
}