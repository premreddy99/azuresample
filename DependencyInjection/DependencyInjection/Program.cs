using Microsoft.Data.SqlClient;
using Repositories;
using Services;
using System.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepo,Repo1>();
builder.Services.AddScoped<IService, Service1>();
//Configure the appsetingJSon
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json",optional:false, reloadOnChange:true)
    .AddEnvironmentVariables()
    .Build();
string connectionString = configuration.GetConnectionString("sqlConnection");

builder.Services.AddScoped<IDbConnection>(provider =>
{
    var connection = new SqlConnection(connectionString);
    return connection;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
