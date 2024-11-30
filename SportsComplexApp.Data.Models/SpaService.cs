using System.ComponentModel.DataAnnotations;
using static SportsComplexApp.Common.EntityValidationConstants.SpaService;

namespace SportsComplexApp.Data.Models;

public class SpaService
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    public string ServiceName { get; set; } = null!;

    [Required]
    [MaxLength(DescriptionMaxLength)]
    public string Description { get; set; } = null!;

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    public int Duration { get; set; }

    [Required]
    [Range((double) PriceMinValue, (double) PriceMaxValue)]
    public decimal Price { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = SpaReservationDate, ApplyFormatInEditMode = true)]
    public DateTime ReservationDate { get; set; }

    public ICollection<SpaReservation> SpaReservations { get; set; } = new List<SpaReservation>();
}