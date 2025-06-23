using Amazon.Extensions.NETCore.Setup;
using Amazon.DynamoDBv2;
using LambdaRegionComunaNet8.Middleware;
using LambdaRegionComunaNet8.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios
builder.Services.AddDefaultAWSOptions(builder.Configuration.GetAWSOptions()); // Configurar AWSOptions
builder.Services.AddAWSService<IAmazonDynamoDB>();
builder.Services.AddSingleton<DynamoDbService>();
builder.Services.AddControllers();

var app = builder.Build();

// Middleware de autenticación por token
app.UseMiddleware<TokenAuthMiddleware>();

// Rutas
app.MapControllers();

// No llames a app.Run() aquí cuando despliegas en Lambda

//// Método necesario para LambdaEntryPoint
//public partial class Program
//{
//    public static void ConfigureWebHostBuilder(IWebHostBuilder builder)
//    {
//        builder
//            .UseStartup<Program>(); // Usa la clase Program como punto de entrada
//    }
//}
