namespace HairSalon.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int StylistId { get; set; }

        public Stylist Stylist { get; set; } = new Stylist();
    }
}