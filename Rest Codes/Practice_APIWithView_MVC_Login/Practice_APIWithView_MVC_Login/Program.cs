using Microsoft.EntityFrameworkCore;
using Practice_APIWithView_MVC_Login.EntityFramework;
using Practice_APIWithView_MVC_Login.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<UserDbContext>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("PracticeConnection")));

builder.Services.AddTransient<IUserProfileRepository, UserProfileRepository>();

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
