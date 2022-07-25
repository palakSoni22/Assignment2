//Program.cs file is having application configuration
using Assignment2.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connString);
});

builder.Services.AddControllersWithViews(); // Add services to the container.
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();//adding this because we haven't instantiated object
//in above lines we are configuring our service
//-----------------------------------------------------------------------------------------------------------------------
var app = builder.Build();
//-----------------------------------------------------------------------------------------------------------------------
//below are the middleware conmponents which will be used in app

if (!app.Environment.IsDevelopment()) // Configure the HTTP request pipeline.
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); //HTTPS makes the data secure
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pie}/{action=List}/{id?}");

app.Run();
