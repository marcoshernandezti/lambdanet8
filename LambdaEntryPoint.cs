using Amazon.Lambda.AspNetCoreServer;
//using Microsoft.AspNetCore.Hosting;

namespace LambdaRegionComunaNet8
{
    public class LambdaEntryPoint : APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder builder)
        {
            // No es necesario configurar UseStartup en .NET 8 con el modelo minimalista
        }
    }
}
