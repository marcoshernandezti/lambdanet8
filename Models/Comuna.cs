using Amazon.DynamoDBv2.DataModel;

namespace LambdaRegionComunaNet8.Models
{
    [DynamoDBTable("Comunas")]
    public class Comuna
    {
        [DynamoDBHashKey]
        public int IdComuna { get; set; }
        [DynamoDBProperty]
        public int? IdRegion { get; set; }
        [DynamoDBProperty]
        public string? NombreComuna { get; set; }
        [DynamoDBProperty]
        public string? InformacionAdicional { get; set; }
    }
}
