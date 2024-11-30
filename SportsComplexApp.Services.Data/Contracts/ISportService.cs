using SportsComplex.Web.ViewModels.Sport;

namespace SportsComplexApp.Services.Data.Contracts;

public interface ISportService
{
    Task<IEnumerable<AllSportsViewModel>> GetAllSportsAsync();
    Task<SportsViewModel?> GetSportByIdAsync(int id);
    Task<SportsDetailsViewModel?> GetSportDetailsAsync(int id);
    Task<IEnumerable<AllSportsViewModel>> GetMySportsAsync(string userId);
    Task AddToMySportsAsync(string userId, SportsViewModel? classesViewModel);
    Task RemoveFromMySportsAsync(string userId, SportsViewModel? classesViewModel);
}