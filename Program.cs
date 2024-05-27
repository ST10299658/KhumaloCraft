using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionstring = builder.Configuration.GetConnectionString("KhumaloCraftContext") ?? throw new Exception("Not found sorry");
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<KhumaloCraft.Models.KhumaloCraftContext>();

builder.Services.AddSession(options =>
{
    // Configure session options here if needed
});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseDeveloperExceptionPage();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=RegisterLogin}/{action=Create}/{id?}");

app.Run();
