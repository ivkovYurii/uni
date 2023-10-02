using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IDataRepository, EFDataRepository>();


builder.Services.AddDbContext<EFDatabaseContext>(op=>
    op.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<ICustomerRepository, EFCustomerRepository>();

builder.Services.AddDbContext<EFCustomerContext>(op=>
    op.UseMySQL(builder.Configuration.GetConnectionString("CustomerConnection")));

// For use MS SQL :
// builder.Services.AddDbContext<EFDatabaseContext>(op=>
//     op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// builder.Services.AddDbContext<EFCustomerContext>(op=>
//     op.UseSqlServer(builder.Configuration.GetConnectionString("CustomerConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}"
    );


app.Run();


// Connection to MS SQL instead of MySQL
// At appsettings.json need to change line on : 
// "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=ProductDb;MultipleActiveResultSets=true"
// "CustomerConnection": "Server=(localdb)\\MSSQLLocalDB;Database=CustomerDb;MultipleActiveResultSets=true"