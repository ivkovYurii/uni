namespace WebApplication1.Models;

public class EFCustomerRepository : ICustomerRepository
{
    private EFCustomerContext _context;

    public EFCustomerRepository(EFCustomerContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Customer> GetAllCustomers()
    {
        return _context.Customers;
    }
}