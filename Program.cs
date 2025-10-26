using Microsoft.EntityFrameworkCore;
using HisVisionHCS.Web.Data;
using HisVisionHCS.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Entity Framework with resilient configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? "Server=hisvision-sql-server.database.windows.net;Database=HisVisionDB;User Id=sqladmin;Password=HisVision2025!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

builder.Services.AddDbContext<HisVisionDbContext>(options =>
{
    options.UseSqlServer(connectionString, sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(maxRetryCount: 3, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
    });
    // Disable automatic migrations and schema validation
    options.EnableSensitiveDataLogging(false);
    options.EnableServiceProviderCaching();
});

// Add Captcha Service
builder.Services.AddScoped<ICaptchaService, CaptchaService>();

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
    name: "employees",
    pattern: "employees",
    defaults: new { controller = "Home", action = "Employees" });


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
