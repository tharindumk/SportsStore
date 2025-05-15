using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(opts => opts.UseSqlServer(builder.Configuration["ConnectionStrings:SportsStoreConnection"]));

builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
