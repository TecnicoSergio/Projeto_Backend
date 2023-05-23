using Microsoft.EntityFrameworkCore;
using RpgApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//COMANDO CONFORME PDF
/*public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoSomee")));
    services.AddControllers();
}*/

//COMANDO CONEXÃO SQL...
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoSomee")));

builder.Services.AddControllers();
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