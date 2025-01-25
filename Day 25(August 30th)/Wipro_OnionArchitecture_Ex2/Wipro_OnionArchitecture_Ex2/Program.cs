using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("PracticeConnection"),
    b => b.MigrationsAssembly("Wipro_OnionArchitecture_Ex2")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddTransient<IDeptRepository, DeptRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();

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
