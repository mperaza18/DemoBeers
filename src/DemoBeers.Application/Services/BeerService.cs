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

            // Some business logic here
            foreach (var beer in allBeers)
            {
                if (beer.AbvPercentage > 5.0m)
                {
                    beer.WarningLabel = true; 
                    continue;

                }
            }

            return allBeers;
        }

        public async Task<Beer> GetBeerByIdAsync(int id)
        {
            var beer = await _beersRepository.GetBeerByIdAsync(id);

            // Some business logic here
            if (beer.AbvPercentage > 5.0m)
            {
                beer.WarningLabel = true;
            }

            return beer;
        }
    }
}
