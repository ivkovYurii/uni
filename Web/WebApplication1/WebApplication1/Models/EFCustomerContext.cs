using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class EFCustomerContext : DbContext
{
    public EFCustomerContext(DbContextOptions<EFCustomerContext> opt)
    : base(opt){}
    
    public DbSet<Customer> Customers { get; set; }
}