using Universidad.API.Middlewares;
using Universidad.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


ConfigurationManager configuration = builder.Configuration;


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<GloblalExceptionHandlingMiddleware>();

builder.Services.ImplementPersistence(builder.Configuration);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<GloblalExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();
