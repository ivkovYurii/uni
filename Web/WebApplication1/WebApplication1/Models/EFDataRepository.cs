using Microsoft.EntityFrameworkCore;

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
        foreach(var a in context.Products)
        {
            if (a.Id == id)
            {
                return a;
            }
        }
        return new Product("defaultName", "defaultCategory", 0m);
    }

    public IEnumerable<Product> GetFilteredProducts(string category = null, decimal? price = null)
    {
        IQueryable<Product> data = context.Products;
        if (category!=null)
        {
            data = data.Where(data => data.Category == category);
        }

        if (price!=null)
        {
            data = data.Where(data => data.Price >= price);
        }

        return data;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return context.Products;
    }

    public void DeleteProduct(int id)
    {
        var product = context.Products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }

    public void UpdateProduct(Product product)
    {
        context.Entry(product).State = EntityState.Modified;
        context.SaveChanges();
    }

    public void CreateProduct(Product product)
    {
        context.Products.Add(product);
        context.SaveChanges();
    }
}