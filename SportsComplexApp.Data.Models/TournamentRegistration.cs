using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SportsComplexApp.Data.Models;

public class TournamentRegistration
{
    [ForeignKey(nameof(Client))] 
    public string ClientId { get; set; } = null!;
    public IdentityUser Client { get; set; } = null!;

    [ForeignKey(nameof(Tournament))] 
    public int TournamentId { get; set; }
    public Tournament Tournament { get; set; } = null!;
}