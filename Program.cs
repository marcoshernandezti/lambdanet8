using Amazon.Extensions.NETCore.Setup;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using LambdaRegionComunaNet8.Middleware;
using LambdaRegionComunaNet8.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios
builder.Services.AddDefaultAWSOptions(builder.Configuration.GetAWSOptions());
builder.Services.AddAWSService<IAmazonDynamoDB>();
builder.Services.AddSingleton<IDynamoDBContext, DynamoDBContext>(); // Registro de DynamoDBContext
builder.Services.AddSingleton<DynamoDbService>();
builder.Services.AddControllers();

var app = builder.Build();

// Middleware de autenticación por token
app.UseMiddleware<TokenAuthMiddleware>();

// Rutas
app.MapControllers();
