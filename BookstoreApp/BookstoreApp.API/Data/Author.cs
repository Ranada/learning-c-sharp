﻿using System;
using System.Collections.Generic;

namespace BookstoreApp.API.Data;

public partial class Author
{
    public Author() { 
        Books = new List<Book>();
    }
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Bio { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
