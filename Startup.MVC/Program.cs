using System;
using Startup.BL;
using Startup.DAL;
using Startup.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("mssql"));
});
//builder.Services.AddDbContext<AppDbContext>(opt =>
//    opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSql"),
//        b => b.MigrationsAssembly("Startup.MVC")));

builder.Services.AddControllersWithViews();
builder.Services.AddService();
builder.Services.AddRepositories();
builder.Services.AddAutoMapper();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "area",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id:guid?}");

app.Run();