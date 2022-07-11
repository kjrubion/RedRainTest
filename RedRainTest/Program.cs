
using RedRain.Domain.Query;
using RedRain.Domain.Repositories;
using RedRain.Infra.Context;
using RedRain.Infra.EntityRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EFContext>();
builder.Services.AddTransient<IEntityRepository,EntityRepositorySP>();
builder.Services.AddTransient<EntityQuery>();
var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();