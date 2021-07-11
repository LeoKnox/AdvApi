namespace AdvApi.Models
{
    public class Room
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Visited {get; set; }
    }
}