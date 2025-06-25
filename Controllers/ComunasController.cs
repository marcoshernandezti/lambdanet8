using LambdaRegionComunaNet8.Models;
using LambdaRegionComunaNet8.Services;
using Microsoft.AspNetCore.Mvc;

namespace LambdaRegionComunaNet8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComunasController : ControllerBase
    {
        private readonly DynamoDbService _dynamoDbService;

        public ComunasController(DynamoDbService dynamoDbService)
        {
            _dynamoDbService = dynamoDbService;
        }

        // GET api/comunas/region/5
        [HttpGet("region/{idRegion:int}")]
        public async Task<ActionResult<IEnumerable<Comuna>>> GetComunasByRegion(int idRegion)
        {
            var comunas = await _dynamoDbService.GetComunasByRegionAsync(idRegion);
            return Ok(comunas);
        }
    }
}
