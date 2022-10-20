using TrattoriApi.Model;
using TrattoriApi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IServiceTrattore, ServiceTrattore>();
builder.Services.AddScoped<IServiceGadget, ServiceGadget>();

builder.Services.AddSingleton<IList<Trattore>>(new List<Trattore>());
builder.Services.AddSingleton<IList<Gadget>>(new List<Gadget>());

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
