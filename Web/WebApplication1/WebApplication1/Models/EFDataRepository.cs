namespace WebApplication1.Models;

public class EFDataRepository : IDataRepository
{
    private EFDatabaseContext context;

    public EFDataRepository(EFDatabaseContext context)
    {
        this.context = context;
    }
    
    
    public Product GetProduct(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return context.Products;
    }

    public void DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void CreateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}