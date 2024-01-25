using DemoBeers.Application.Services;
using DemoBeers.Persistance.Repositories;
using DemoBeers.Test.Stubs;
using Moq;

namespace DemoBeers.Test.Services
{
    public class BeerServiceTest_Start
    {
        private readonly BeerService _beerService;
        private readonly IBeersRepository _beersRepository;
        private readonly StubBeersRepository _stubBeersRepository;

        public BeerServiceTest_Start()
        {
            _stubBeersRepository = new StubBeersRepository();
            _beersRepository = Mock.Of<IBeersRepository>();
            _beerService = new BeerService(_beersRepository);
        }

        [Fact]
        public async Task GivenThereAreBeers_WhenPassingId_ThenShouldReturnASingleBeer()
        {
            // Arrenge

            // Act

            // Assert
        }

        [Fact]
        public async Task GivenThereAreBeers_WhenRequestingAll_ThenShouldReturnAList()
        {
            // Arrenge

            // Act

            // Assert
        }
    }
}
