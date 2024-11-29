<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using static SportsComplexApp.Common.EntityValidationConstants.MembershipType;

namespace SportsComplexApp.Data.Models;

public class MembershipType
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(TypeNameMaxLength)]
    public string TypeName { get; set; } = null!;

    [Required]
    [Range((double) PriceMinValue , (double) PriceMaxValue)]
    public decimal Price { get; set; }

    public ICollection<Member> Members { get; set; } = new List<Member>();

=======
﻿using System.ComponentModel.DataAnnotations;
using static SportsComplexApp.Common.EntityValidationConstants.MembershipType;

namespace SportsComplexApp.Data.Models;

public class MembershipType
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(TypeNameMaxLength)]
    public string TypeName { get; set; } = null!;

    [Required]
    [Range((double) PriceMinValue , (double) PriceMaxValue)]
    public decimal Price { get; set; }

    public ICollection<Member> Members { get; set; } = new List<Member>();

>>>>>>> aa4ebc202dfbfd35654d1dcb4f4b39138255a65d
}