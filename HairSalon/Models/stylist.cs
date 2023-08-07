using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name {get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public string Wage { get; set; } = string.Empty;
    public List<Client> Clients {get; set; } = new List<Client>();
  }
}