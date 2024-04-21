using Microsoft.EntityFrameworkCore;
using Crud.Data;
using Crud.Models;
using Microsoft.Extensions.Options;
using Crud.Repository;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoryService, CategoryServiceImpl>();
builder.Services.AddScoped <ICustomerService, CustomerServiceImpl>();
/*builder.Services.AddDbContext<EntityDbContext>()*/;

///services connection database with constructor 
var connectionString = builder.Configuration.GetConnectionString("MyConnection");
builder.Services.AddDbContext<EntityDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});



var app = builder.Build();
app.UseStaticFiles();

//Configuration Request Pineline
app.MapDefaultControllerRoute();

app.Run();
