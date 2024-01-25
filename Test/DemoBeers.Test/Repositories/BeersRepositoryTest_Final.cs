using DemoBeers.Test.Stubs;

namespace DemoBeers.Test.Repositories
{
    public class BeersRepositoryTest_Final
    {
        private readonly StubBeersRepository _stubBeersRepository;

        public BeersRepositoryTest_Final()
        {
            _stubBeersRepository = new StubBeersRepository();
        }

        [Fact]
        public async Task GivenThereAreBeers_WhenPassingId_ThenShouldReturnASingleBeer()
        {
            // Arrenge
            var beerId = 1;

            // Act
            var expectedBeer = await _stubBeersRepository.GetBeerByIdAsync(beerId);

            // Assert
            Assert.Equal("Boston Lager", expectedBeer.Name);

        }

        [Fact]
        public async Task GivenThereAreBeers_WhenRequestingAll_ThenShouldReturnAList()
        {
            // Arrenge
            var expectedBeersCount = 5;

            // Act
            var expectedBeers = (await _stubBeersRepository.GetAllBeers()).ToList();

            // Assert
            Assert.Equal(expectedBeersCount, expectedBeers.Count());
        }
    }
}
