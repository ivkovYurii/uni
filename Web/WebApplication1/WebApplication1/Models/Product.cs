using System.Net.Sockets;

namespace WebApplication1.Models
{
    public class Product
    {
        private static int instanceId;
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }

        public Product(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
			Id = instanceId++;
        }
    }
}
