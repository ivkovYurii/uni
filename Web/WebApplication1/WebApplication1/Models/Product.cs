using System.Net.Sockets;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public Product()
        {
        }
        public Product(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
