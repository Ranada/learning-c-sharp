using System;

namespace Defining;

public class Book
{
    string _title;
    string _author;
    int _pages;

    public Book(string title, string author, int pages)
    {
        // Access default is Private
        _title = title;
        _author = author;
        _pages = pages;
    }

    public string GetDescription()
    {
        return $"{_title} by {_author}";
    }

    // TODO: use Properties to implement access to our internal data
    // This is called a Property with a "backing field"
    public string Title {
        get {
            return _title;
        }
        set {
            _title = value;
        }
    }

}