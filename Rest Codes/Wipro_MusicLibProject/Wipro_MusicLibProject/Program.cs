using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("MusicLibConnection"),
    b => b.MigrationsAssembly("Wipro_MusicLibProject")));

builder.Services.AddTransient<IUserRepository,  UserRepository>();
builder.Services.AddTransient<ILoginRepository, LoginRepository>();

builder.Services.AddAuthentication(defaultScheme: "Cookies")
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Login";
        options.AccessDeniedPath = "/Login/Login/";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
    //name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Login}/{action=Login}/{id?}");
});

app.Run();
