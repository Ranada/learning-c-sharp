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
                    new Book { Title = "Cat in the Hat", CallNumber = "ASDF1234" },
                    new Book { Title = "Green Eggs and Ham", CallNumber = "ASDF3456" },
                    new Book { Title = "The Grinch Who Stole Christmas", CallNumber = "ASDF7800" }
                    );
                context.SaveChanges();
            }
        }
    }
}
