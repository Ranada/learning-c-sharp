using System.ComponentModel.DataAnnotations;

namespace ContosoPizzaApi.Models
{
    public class PizzaSpecial
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = "";
        public decimal BasePrice { get; set; }
        public string Description { get; set; } = "Default description";
        public string ImageUrl { get; set; } = "No image URL yet.";
        public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
    }
}
