using System.ComponentModel.DataAnnotations.Schema;

namespace SportsComplexApp.Data.Models;

public class TournamentRegistration
{
    [ForeignKey(nameof(Client))] 
    public string ClientId { get; set; } = null!;
    public Client Client { get; set; } = null!;

    [ForeignKey(nameof(Tournament))] 
    public int TournamentId { get; set; }
    public Tournament Tournament { get; set; } = null!;
}