namespace WebApplication1.Models;

public interface IDataRepository
{
    Product GetProduct(int id);
    
    IEnumerable<Product> GetAllProducts();
    
    void DeleteProduct(int id);
    void UpdateProduct(Product product);
    void CreateProduct(Product product);
}