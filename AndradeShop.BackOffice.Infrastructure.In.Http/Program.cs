using AndradeShop.BackOffice.Infrastructure.CrossCutting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationWithDependencies(builder.Configuration
    .GetConnectionString("DefaultConnection")!, builder.Configuration
    .GetSection("BusServiceConnection:Kafka").Value!);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
