using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication1;

public class AppUser
{
    public int? Pace { get; set; }
    public int? Mileage { get; set; }
    public string? ProfileImageUrl { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }


    [ForeignKey("Address")]
    public int? AddressId { get; set; }
    public Address? Address { get; set; }
    public ICollection<Club>? Clubs { get; set; }
    public ICollection<Race>? Races { get; set; }

    // Collection<Club> Clubs { get; set; }

}
