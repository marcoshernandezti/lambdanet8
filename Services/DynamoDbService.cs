using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using LambdaRegionComunaNet8.Models;

namespace LambdaRegionComunaNet8.Services
{
    public class DynamoDbService
    {
        private readonly IDynamoDBContext _context;

        public DynamoDbService(IDynamoDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Region>> GetRegionesAsync()
        {
            var regiones = await _context.ScanAsync<Region>(new List<ScanCondition>()).GetRemainingAsync();
            return regiones;
        }

        public async Task<IEnumerable<Comuna>> GetComunasByRegionAsync(int idRegion)
        {
            var conditions = new List<ScanCondition>
            {
                new ScanCondition("IdRegion", ScanOperator.Equal, idRegion)
            };
            var comunas = await _context.ScanAsync<Comuna>(conditions).GetRemainingAsync();
            return comunas;
        }
    }
}
