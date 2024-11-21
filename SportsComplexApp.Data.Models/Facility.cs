using System.ComponentModel.DataAnnotations;

namespace SportsComplexApp.Data.Models;

public class Facility
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    
    [MaxLength(100)]
    public string Location { get; set; }

    public int Capacity { get; set; }

    public ICollection<Sport> Sports { get; set; }
}