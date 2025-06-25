using LambdaRegionComunaNet8.Models;
using LambdaRegionComunaNet8.Services;
using Microsoft.AspNetCore.Mvc;

namespace LambdaRegionComunaNet8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionesController : ControllerBase
    {
        private readonly DynamoDbService _dynamoDbService;

        public RegionesController(DynamoDbService dynamoDbService)
        {
            _dynamoDbService = dynamoDbService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Region>>> GetRegiones()
        {
            var regiones = await _dynamoDbService.GetRegionesAsync();
            return Ok(regiones);
        }
    }
}
