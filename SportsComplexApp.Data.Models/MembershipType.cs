using System.ComponentModel.DataAnnotations;

namespace SportsComplexApp.Data.Models;

public class MembershipType
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string TypeName { get; set; }
    public decimal Price { get; set; }
    public ICollection<Member> Members { get; set; }

}