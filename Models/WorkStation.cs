namespace DemoApiDotnet7.Models
{
    public class WorkStation
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public ICollection<Asset> Assets { get; set; }
    }
}