using System.ComponentModel.DataAnnotations;

namespace SportsComplexApp.Data.Models;

public class SpaService
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string ServiceName { get; set; }

    [MaxLength(200)]
    public string Description { get; set; }

    public int Duration { get; set; }

    public decimal Price { get; set; }

    public ICollection<SpaReservation> SpaReservations { get; set; }
}