using MeuProjetoCRUD.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddAuthorization();
builder.Services.AddControllers();// Adiciona a autorização 

// Add services to the container.
builder.Services.AddDbContext<UsuarioContext>(options =>
{
  options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"));
});

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