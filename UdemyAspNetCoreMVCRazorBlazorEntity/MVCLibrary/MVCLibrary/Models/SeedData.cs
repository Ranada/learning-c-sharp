using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(
                serviceProvider
                .GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }
                context.Book.AddRange(
                    new Book { Title = "Cat in the Hat", Author = "Dr. Suess", CallNumber = "ASDF1234" },
                    new Book { Title = "Green Eggs and Ham", Author = "Dr. Suess", CallNumber = "ASDF3456" },
                    new Book { Title = "The Grinch Who Stole Christmas", Author = "Dr. Suess", CallNumber = "ASDF7800" }
                    );
                context.SaveChanges();
            }
        }
    }
}
