using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Services.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SmartHmsdbContext>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IPatientRepository, PatientRepository>();
builder.Services.AddTransient<IDoctorRepository, DoctorRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<ILoginRepository, LoginRepository>();
builder.Services.AddTransient<IAppointmentRepository, AppointmentRepository>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
