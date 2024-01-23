using DemoBeers.Domain.Entities;

namespace DemoBeers.Application.Services
{
    public interface IBeerService
    {
        Task<Beer> GetBeerByIdAsync(int id);
        Task<IEnumerable<Beer>> GetAllBeers();
    }
}
