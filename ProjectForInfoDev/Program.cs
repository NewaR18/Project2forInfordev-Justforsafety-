using Microsoft.EntityFrameworkCore;
using ProjectForInfoDev.Models;
using ProjectForInfoDev.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var constr = builder.Configuration.GetConnectionString("myconnection");
builder.Services.AddDbContext<BloodContext>(options => options.UseSqlServer(constr));
builder.Services.AddScoped<IBloodRepo, BloodRepo>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Blood}/{action=Home}/{id?}");

app.Run();
