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
    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = value;
        }
    }

    // TODO: Shorthand way of writing the above using the => operator to create "expression-bodied" properties
    public string Author
    {
        get => _author;
        set => _author = value;
    }
    public int Pages
    {
        get => _pages;
        set => _pages = value;
    }

    // TODO: Omit the get or set to prevent reading or modification. Here's and example of ommitting set
    public string Description
    {
        get => $"{Title} by {Author}, {Pages} pages";
    }





}