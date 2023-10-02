using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class MigrationsManager
{
    private IServiceProvider provider;
    private IEnumerable<Type> ContextType;
    private IEnumerable<string> ContextNames;
    public string ContextName { get; set; }

    public MigrationsManager(IServiceProvider provider)
    {
        this.provider = provider;
        ContextType = provider.GetServices<DbContextOptions>().Select(t => t.ContextType);
        ContextNames = ContextType.Select(t => t.FullName);
        ContextName = ContextNames.First();
    }
    
    
    
}