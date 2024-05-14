using MVC_CodeFirst.Areas.Dashboard.Models.Abstracts;
using MVC_CodeFirst.Areas.Dashboard.Models.Concretes;

var builder = WebApplication.CreateBuilder(args);
//MVC
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IGenreRepository, GenreRepository>();
var app = builder.Build();

//staticfiles
app.UseStaticFiles();
//route
app.UseRouting();
//maproute

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}"
    );


    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
