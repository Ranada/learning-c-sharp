using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.API.Models.Book
{
    public class BookUpdateDto :BaseDto
    {
        [StringLength(50)]
        public string Title { get; set; }

        [Range(1800, int.MaxValue)]
        public int Year { get; set; }

        public string Isbn { get; set; }

        [StringLength(250, MinimumLength = 10)]
        public string Summary { get; set; }

        public string Image { get; set; }

        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int AuthorId { get; set; }
    }
}
