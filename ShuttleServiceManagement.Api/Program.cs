using Scrutor;
using ShuttleServiceManagement.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Scan(selector => selector.FromAssemblies(ShuttleServiceManagement.Persistence.AssemblyReference.Assembly)
.AddClasses(false)
.UsingRegistrationStrategy(RegistrationStrategy.Skip)
.AsImplementedInterfaces()
.WithScopedLifetime());

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(ShuttleServiceManagement.Application.AssemblyReference)));

builder.Services.AddDbContext<AppDbContext>();

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
