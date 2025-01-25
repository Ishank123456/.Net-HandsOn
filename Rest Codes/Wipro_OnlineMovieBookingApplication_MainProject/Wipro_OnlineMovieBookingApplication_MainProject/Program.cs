using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("OnlineMovieBookingConnection"),
    b => b.MigrationsAssembly("Wipro_OnlineMovieBookingApplication_MainProject")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<ILoginRepository, LoginRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
