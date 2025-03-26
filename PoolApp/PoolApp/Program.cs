using Microsoft.EntityFrameworkCore;
using PoolApp.Data;
using PoolApp.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages(options =>
{
    options.Conventions.AddPageRoute("/Identity/Account/Login", "/");  // Redirects the root to the login page
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";  // Customize your login path if needed
    options.AccessDeniedPath = "/Account/AccessDenied";  // Optional: path when access is denied
});

builder.Services.AddDbContext<PoolAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

// Add Identity services
builder.Services.AddDefaultIdentity<PoolTech>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;
})
.AddEntityFrameworkStores<PoolAppContext>()
.AddDefaultUI();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages(); // Enables Identity UI


app.Run();
