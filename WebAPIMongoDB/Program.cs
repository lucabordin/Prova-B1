using WebAPIMongoDB.DataAccess;
using WebAPIMongoDB.Model;
using WebAPIMongoDB.Repository;
using WebAPIMongoDB.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//LEGGE ED INIETTA LA CONFIGURAZIONE MONGO
builder.Services.Configure<DatabaseSettings>(
builder.Configuration.GetSection("DatabaseSettings"));

//INJECTION Context e Repository
builder.Services.AddScoped<DatabaseSettings, DatabaseSettings>();
builder.Services.AddScoped<IContext, Context>();
builder.Services.AddScoped<IMongoService, MongoService>();
builder.Services.AddScoped<IMongoRepository, MongoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
