using System.ComponentModel.DataAnnotations;
using static SportsComplexApp.Common.EntityValidationConstants.Tournament;

namespace SportsComplexApp.Data.Models;

public class Tournament
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(DescriptionMaxLength)]
    public string Description { get; set; } = null!;

    [Required]
    [MaxLength(LocationMaxLength)]
    public string Location { get; set; } = null!;

    [Required]
    [Range((double)MinPriceValue, (double)MaxPriceValue)]
    public decimal Price { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = TournamentStartDate, ApplyFormatInEditMode = true)]
    public DateTime StartDate { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = TournamentEndDate,  ApplyFormatInEditMode = true)]
    public DateTime EndDate { get; set; }

    public ICollection<TournamentRegistration> TournamentRegistrations { get; set; } =
        new List<TournamentRegistration>();
}