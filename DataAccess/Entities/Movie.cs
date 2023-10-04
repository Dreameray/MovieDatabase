#nullable disable
namespace DataAccess.Entities;

public class Movie: Record
{
    public string Name { get; set; }

    public short Year { get; set; }

    public double Revenue { get; set; }

    public int DirectorId { get; set; }

    public Director Director { get; set; }
}
