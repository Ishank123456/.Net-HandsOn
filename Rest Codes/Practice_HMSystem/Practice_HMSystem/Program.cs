using Microsoft.EntityFrameworkCore;
using Practice_HMSystem.EntityFramework;
using Practice_HMSystem.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IPatientRepository, PatientRepository>();
builder.Services.AddTransient<IDoctorRepository, DoctorRepository>();

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
