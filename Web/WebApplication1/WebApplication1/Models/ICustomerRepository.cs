namespace WebApplication1.Models;

public interface ICustomerRepository
{
    IEnumerable<Customer> GetAllCustomers();
}