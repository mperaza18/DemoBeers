using DemoBeers.Domain.Entities;

namespace DemoBeers.Persistance.Repositories
{
    public interface IBeersRepository
    {
        Task<Beer> GetBeerByIdAsync(int id);
        Task<IEnumerable<Beer>> GetAllBeers();
    }
}
