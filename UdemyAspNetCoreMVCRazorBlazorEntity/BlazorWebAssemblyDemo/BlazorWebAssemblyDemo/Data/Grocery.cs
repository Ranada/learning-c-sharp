using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblyDemo.Data
{
    public class Grocery
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should be less than 15 characters.")]
        public string Name { get; set; }

        [Required]
        [Range(1,10000, ErrorMessage = "Valid price range is (1-10000)")]
        public decimal Price { get; set; }

        public Grocery(string name = "", decimal price = 0)
        {
            Name = name;
            Price = price;
        }
    }
}
