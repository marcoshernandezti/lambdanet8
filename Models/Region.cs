namespace LambdaRegionComunaNet8.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public virtual ICollection<Comuna>? Comunas { get; set; }
    }
}
