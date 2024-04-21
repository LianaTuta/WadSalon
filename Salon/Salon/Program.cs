using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Salon.BL;
using Salon.DAL;
using Salon.Migrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddServices();
builder.Services.AddRepositories();
builder.Services.AddDbContext<SalonContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SalonDb")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles(
    new StaticFileOptions()
    {
        FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Images")),
        RequestPath = new PathString("/Images")
    });
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
