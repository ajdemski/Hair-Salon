using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int Id { get; set; }
    public string Name {get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
  }
}