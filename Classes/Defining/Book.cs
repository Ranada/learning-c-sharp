using System;

namespace Defining;

public class Book
{
    string _title;
    string _author;
    int _pages;

    public Book(string title, string author, int pages)
    {
        _title = title;
        _author = author;
        _pages = pages;
    }

    public string GetDescription()
    {
        return $"{_title} by {_author}";
    }
}