using System.ComponentModel.DataAnnotations;
using static SportsComplexApp.Common.EntityValidationConstants.Facility;

namespace SportsComplexApp.Data.Models;

public class Facility
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(LocationMaxLength)]
    public string Location { get; set; } = null!;

    [Required]
    [Range(CapacityMinValue, CapacityMaxValue)]
    public int Capacity { get; set; }

    public ICollection<Sport> Sports { get; set; } = new List<Sport>();
}