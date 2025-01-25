using Microsoft.EntityFrameworkCore;
using Wipro_API_Customer_Service.EntityFramework;
using Wipro_API_Customer_Service.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//.Net core framework will allocate the memory for applicationDbContext Class
builder.Services.AddDbContext<ApplicationDbContext>
    (cm => cm.UseSqlServer(builder.Configuration.GetConnectionString("CustomerConnection")));

//per call object
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
