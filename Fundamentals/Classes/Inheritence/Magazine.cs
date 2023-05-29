namespace Inheritence;

class Magazine : Publication
{
    string _publisher;

    public Magazine(string title, int pages, decimal price, string publisher)
     : base(title, pages, price)
    {
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

    public override string ToString()
    {
        return $"Override ToString -> {Title}, {Publisher}, {Pages:C}, {Price}";
    }

    public string ToString(string format)
    {
        if (format.ToLower() == "short")
        {
            return $"Short format -> {Title}:{Publisher}:{Pages}:{Price:C}";

        }
        if (format.ToLower() == "long")
        {
            return $"Long format -> Title: {Title}, Publisher: {Publisher}, {Pages} pages, Price: {Price:C}";

        }
        return ToString();
    }
}