﻿using System.ComponentModel.DataAnnotations;
using SportsComplexApp.Common;
using static SportsComplexApp.Common.EntityValidationConstants.Trainer;

namespace SportsComplexApp.Data.Models;

public class Trainer
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(FirstNameMaxLength)]
    public string FirstName { get; set; } = null!;

    [Required]
    [MaxLength(LastNameMaxLength)]
    public string LastName { get; set; } = null!;

    [Required]
    [MaxLength(SpecializationMaxLength)]
    public string Specialization { get; set; } = null!;

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = TrainerHireDate, ApplyFormatInEditMode = true)]
    public DateTime HireDate { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = TrainerSessionDate, ApplyFormatInEditMode = true)]
    public DateTime SessionDate { get; set; }

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    public int SessionDuration { get; set; }

    public ICollection<TrainerSession> TrainersSessions { get; set; } = new List<TrainerSession>();

}