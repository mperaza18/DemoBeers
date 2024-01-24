using DemoBeers.Application.Services;
using DemoBeers.Persistance.Repositories;
using Moq;

namespace DemoBeers.Test.Services
{
    public class BeerServiceTest_Start
    {
        private readonly BeerService _beerService;
        private readonly IBeersRepository _beersRepository;

        public BeerServiceTest_Start()
        {
            _beersRepository = Mock.Of<IBeersRepository>();
            _beerService = new BeerService(_beersRepository);
        }

        [Fact]
        public async Task GivenThereAreBeers_WhenPassingId_ThenShouldReturnASingleBeer_Final()
        {
            // Arrenge

            // Act

            // Arrenge
        }

        [Fact]
        public async Task GivenThereAreBeers_WhenRequestingAll_ThenShouldReturnAList()
        {
            // Arrenge

            // Act

            // Arrenge
        }
    }
}
