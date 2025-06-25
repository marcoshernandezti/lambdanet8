using Amazon.DynamoDBv2.DataModel;

namespace LambdaRegionComunaNet8.Models
{
    [DynamoDBTable("Regiones")]
    public class Region
    {
        [DynamoDBHashKey]
        public int Id { get; set; }
        [DynamoDBProperty]
        public string Nombre { get; set; } = string.Empty;
        public virtual ICollection<Comuna>? Comunas { get; set; }
    }
}
