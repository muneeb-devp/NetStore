using Microsoft.EntityFrameworkCore;
using NetStore.Data;
using Tailwind;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(
    builder.Configuration.GetConnectionString("default"))
);

var app = builder.Build();

if (app.Environment.IsDevelopment()) _ = app.RunTailwind("tailwind", "./");

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapDefaultControllerRoute();

app.Run();