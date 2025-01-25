using Microsoft.EntityFrameworkCore;
using Wipro_API_CFA_VehicleService.EntityFramework;
using Wipro_API_CFA_VehicleService.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<VehicleDbContext>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("VehicleConnection")));

builder.Services.AddTransient<IVehicleRepository, VehicleRepository>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
