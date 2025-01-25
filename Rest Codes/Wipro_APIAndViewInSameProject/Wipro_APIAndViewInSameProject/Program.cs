using Microsoft.EntityFrameworkCore;
using Wipro_APIAndViewInSameProject.EntityFramework;
using Wipro_APIAndViewInSameProject.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CustomerDbContext>
	(tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("CustomerConnection")));

builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();

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
