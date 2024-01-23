using DemoBeers.Domain.Entities;
using DemoBeers.Persistance.Repositories;

namespace DemoBeers.Application.Services
{
    public class BeerService : IBeerService
    {
        private readonly IBeersRepository _beersRepository;
        public BeerService(IBeersRepository beersRepository)
        {
            _beersRepository = beersRepository;
        }

        public async Task<IEnumerable<Beer>> GetAllBeers()
        {
            var allBeers = await _beersRepository.GetAllBeers();
            return allBeers;
        }

        public async Task<Beer> GetBeerByIdAsync(int id)
        {
            var beer = await _beersRepository.GetBeerByIdAsync(id);
            return beer;
        }
    }
}
