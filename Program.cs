using Microsoft.EntityFrameworkCore;
using OracleAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string cadena = "Data Source= (DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=xe)));User Id=dantelopez;password=123456;";
builder.Services.AddControllers();
builder.Services.AddDbContext<ContextOracle>(
    options => options.UseOracle(cadena)
    );
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
