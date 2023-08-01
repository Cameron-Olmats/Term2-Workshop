using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using TravelExpertsData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//builder.Services.AddMvc(options => options.MaxModelValidationErrors = 1); Doesn't work. Wanted one error at a time.

builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<TravelExpertsContext>(
    options => options.UseSqlServer
    (builder.Configuration.GetConnectionString("TEConnection")));



builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt => opt.LoginPath="/Customer/Login");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
