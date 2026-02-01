using ModernDotNetFramework.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Custom Services
builder.Services.AddScoped<ISimpleLogger, SimpleLogger>();

var app = builder.Build();

// Configure the HTTP request pipeline.
// Enable Swagger for both Development and Production for demonstration purposes
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
