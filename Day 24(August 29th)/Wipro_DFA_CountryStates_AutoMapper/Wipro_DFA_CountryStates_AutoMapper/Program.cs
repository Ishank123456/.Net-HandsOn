using Microsoft.EntityFrameworkCore;
using Wipro_DFA_CountryStates_AutoMapper.EntityFramework;
using Wipro_DFA_CountryStates_AutoMapper.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<Wipro29082024Context>
    (tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("CountryStatesConnection")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddTransient<ICountryRepository, CountryRepository>();
builder.Services.AddTransient<IStateRepository, StateRepository>();


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
