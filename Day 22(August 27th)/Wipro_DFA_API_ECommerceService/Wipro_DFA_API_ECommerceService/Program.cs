using Microsoft.EntityFrameworkCore;
using Wipro_DFA_API_ECommerceService.EntityFramework;
using Wipro_DFA_API_ECommerceService.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<WiproDfa26082024Context>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("CustomerConnection")));

builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<IOrderTableInfoRepository, OrderTableInfoRepository>();

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
