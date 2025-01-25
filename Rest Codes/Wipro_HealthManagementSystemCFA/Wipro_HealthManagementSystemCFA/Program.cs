using Microsoft.EntityFrameworkCore;
using Wipro_HealthManagementSystemCFA.EntityFramework;
using Wipro_HealthManagementSystemCFA.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IPatientRepository, PatientRepository>();

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
