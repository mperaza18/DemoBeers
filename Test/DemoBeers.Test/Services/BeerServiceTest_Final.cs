using DemoBeers.Application.Services;
using DemoBeers.Domain.Entities;
using DemoBeers.Persistance.Repositories;
using DemoBeers.Test.Stubs;
using Moq;

namespace DemoBeers.Test.Services
{
    public class BeerServiceTest_Final
    {
        private readonly BeerService _beerService;
        private readonly IBeersRepository _beersRepository;
        private readonly StubBeersRepository _stubBeersRepository;

        public BeerServiceTest_Final()
        {
            _stubBeersRepository = new StubBeersRepository();
            _beersRepository = Mock.Of<IBeersRepository>();
            _beerService = new BeerService(_beersRepository);
        }

        [Fact]
        public async Task GivenThereAreBeers_WhenPassingId_ThenShouldReturnASingleBeer()
        {
            // Arrenge
            var beerId = 1;
            // We can use Stub here.
            var expectedBeer = new Beer
            {
                Id = 1,
                Name = "Boston Lager",
                Pack = "6, 12, 28",
                AbvPercentage = 5.0m,
                Ibu = 30,
                Description = "An amber lager and the flagship product of Boston Brewing Company."
            };

            Mock.Get(_beersRepository)
                .Setup(x => x.GetBeerByIdAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(expectedBeer))
                .Verifiable();

            // Act
            var result = await _beerService.GetBeerByIdAsync(beerId);

            // Assert
            Assert.Equal(expectedBeer.Name, result.Name);
        }

        [Fact]
        public async Task GivenThereAreBeers_WhenRequestingAll_ThenShouldReturnAList()
        {
            var expectedBeers = (await _stubBeersRepository.GetAllBeers()).ToList();

            Mock.Get(_beersRepository)
                .Setup(x => x.GetAllBeers())
                .ReturnsAsync(expectedBeers)
                .Verifiable();

            // Act
            var result = await _beersRepository.GetAllBeers();

            // Assert
            Assert.Equal(expectedBeers.Count, result.Count());
        }
    }
}
