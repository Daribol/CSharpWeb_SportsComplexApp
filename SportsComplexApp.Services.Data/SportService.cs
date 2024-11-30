using Microsoft.EntityFrameworkCore;
using SportsComplex.Web.ViewModels.Facility;
using SportsComplex.Web.ViewModels.Sport;
using SportsComplexApp.Data;
using SportsComplexApp.Data.Models;
using SportsComplexApp.Services.Data.Contracts;

namespace SportsComplexApp.Services.Data;

public class SportService : ISportService
{
    private readonly SportsComplexDbContext _context;

    public SportService(SportsComplexDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<AllSportsViewModel>> GetAllSportsAsync()
    {
        return await _context.Sports
            .Select(s => new AllSportsViewModel()
            {
                Id = s.Id,
                Name = s.Name,
                ImageUrl = s.ImageUrl
            })
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<SportsViewModel?> GetSportByIdAsync(int id)
    {
        return await _context.Sports
            .Where(s => s.Id == id)
            .Select(s => new SportsViewModel()
            {
                Id = s.Id,
                Name = s.Name
            })
            .AsNoTracking()
            .FirstOrDefaultAsync();
    }

    public async Task<SportsDetailsViewModel?> GetSportDetailsAsync(int id)
    {
        return await _context.Sports
            .Where(s => s.Id == id)
            .Select(s => new SportsDetailsViewModel
            {
                Id = s.Id,
                Name = s.Name,
                ImageUrl = s.ImageUrl,
                Facility = new FacilityViewModel()
                {
                    Name = s.Facility.Name,
                    Location = s.Facility.Location,
                    Capacity = s.Facility.Capacity,
                }
            })
            .FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<AllSportsViewModel>> GetMySportsAsync(string userId)
    {
        return await _context.Reservations
            .Where(r => r.ClientId == userId)
            .Select(r => new AllSportsViewModel
            {
                Id = r.Sport.Id,
                Name = r.Sport.Name,
                ImageUrl = r.Sport.ImageUrl,
            })
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task AddToMySportsAsync(string userId, SportsViewModel? sports)
    {
        if (sports != null)
        {
            var sportEntity = await _context.Sports.FindAsync(sports.Id);

            if (sportEntity == null)
            {
                throw new InvalidOperationException("This sport doesn't exist!");
            }
        }

        var existingReservation = await _context.Reservations
            .FirstOrDefaultAsync(r => r.ClientId == userId && r.SportId == sports.Id);

        if (existingReservation != null)
        {
            throw new InvalidOperationException("You have a reservation for this sport!");
        }

        var sportReservation = new Reservation()
        {
            ClientId = userId,
            SportId = sports.Id
        };

        await _context.Reservations.AddAsync(sportReservation);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveFromMySportsAsync(string userId, SportsViewModel sports)
    {
        var sportReservation = await _context.Reservations
            .FirstOrDefaultAsync(r => r.ClientId == userId && r.SportId == sports.Id);

        if (sportReservation == null)
        {
            throw new InvalidOperationException("You haven't reservation for this sport");
        }

        _context.Reservations.Remove(sportReservation);
        await _context.SaveChangesAsync();
    }
}