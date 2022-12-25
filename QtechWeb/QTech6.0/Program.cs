using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRequestsService, RequestsMan>();
builder.Services.AddScoped<IUserService, UserMan>();
builder.Services.AddScoped<IRequests, RequestsRepo>();
builder.Services.AddScoped<IUser, UserRepo>();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation().AddNToastNotifyToastr(new ToastrOptions()
{
    Title = "Bilgilendirme"

});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
   AddCookie(x =>
   {
       x.LoginPath = "/Login/Index";
   }
);
builder.Services.AddAuthenticationCore();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
