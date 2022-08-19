//using Shopping.API;

var builder = WebApplication.CreateBuilder(args); // existed

//var startup = new Startup(builder.Configuration);
//startup.ConfigureServices(builder.Services); // calling ConfigureServices method

// Add services to the container.

builder.Services.AddControllers();

//startup.Configure(app, builder.Environment); // calling Configure method

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build(); // existed

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
