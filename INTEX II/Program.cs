using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using INTEX_II.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Configure the DbContext for your application
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add Identity services to the container
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    // Configure password requirements
    options.Password.RequiredLength = 8; // Minimum password length
    options.Password.RequireUppercase = true; // Require at least one uppercase letter
    options.Password.RequireLowercase = true; // Require at least one lowercase letter
    options.Password.RequireDigit = true; // Require at least one digit
    options.Password.RequireNonAlphanumeric = true; // Require at least one special character
    options.SignIn.RequireConfirmedAccount = true;
})
.AddEntityFrameworkStores<ApplicationDbContext>(); // Configure Identity to use ApplicationDbContext

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllersWithViews();

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential
    // cookies is needed for a given request.
    options.CheckConsentNeeded = context => !context.Request.Cookies.ContainsKey("CookieConsent");
    options.MinimumSameSitePolicy = SameSiteMode.None;
    options.ConsentCookie.Name = "CookieConsent"; // Set the name of the cookie
});

// Add Google Authentication to the project
builder.Services.AddAuthentication().AddGoogle(googleOptions =>
{
    googleOptions.ClientId = Environment.GetEnvironmentVariable("GOOGLE_CLIENT_ID");
    googleOptions.ClientSecret = Environment.GetEnvironmentVariable("GOOGLE_CLIENT_SECRET");
});

var app = builder.Build();

// Enable the Content-Security-Policy (CSP) HTTP header
app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'");
    await next.Invoke();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");

    // Enable HTTP Strict Transport Security (HSTS)
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCookiePolicy();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
