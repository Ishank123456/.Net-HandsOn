using Microsoft.EntityFrameworkCore;
using Wipro_API_ProductService.EntityFramework;
using Wipro_API_ProductService.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ProductDbContext>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("ProductConnection")));

builder.Services.AddTransient<IProductRepository, ProductRepository>();

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
