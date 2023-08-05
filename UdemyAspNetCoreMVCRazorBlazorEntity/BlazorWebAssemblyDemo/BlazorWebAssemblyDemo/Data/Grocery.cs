namespace BlazorWebAssemblyDemo.Data
{
    public class Grocery
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Grocery(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
