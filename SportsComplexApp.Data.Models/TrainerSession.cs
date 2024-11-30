using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SportsComplexApp.Data.Models;

public class TrainerSession
{
    [ForeignKey(nameof(Trainer))] 
    public string TrainerId { get; set; } = null!;
    public IdentityUser Trainer { get; set; } = null!;

    [ForeignKey(nameof(Client))]
    public int ClientId { get; set; }
    public Client Client { get; set; } = null!;
}