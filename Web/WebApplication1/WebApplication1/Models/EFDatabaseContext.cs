using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
	public class EFDatabaseContext : DbContext
	{
		public EFDatabaseContext(DbContextOptions<EFDatabaseContext> options) : base(options) { }
		public DbSet<Product> Products { get; set; }
	}
}
