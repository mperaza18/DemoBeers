using DemoBeers.Domain.Entities;
using DemoBeers.Persistance.Repositories;
using Moq;

namespace DemoBeers.Test.Repositories
{
    public class BeersRepositoryTest_Final
    {
        private readonly BeersRepository _beersRepository;

        public BeersRepositoryTest_Final()
        {
            _beersRepository = new BeersRepository();
        }

        [Fact]
        public async Task GivenThereAreBeers_WhenPassingId_ThenShouldReturnASingleBeer()
        {
            // Arrenge
            var beerId = 1;
            var expectedBeer = new Beer 
            {
                Id = 1,
                Name = "Boston Lager",
                Pack = "6, 12, 28",
                AbvPercentage = 5.0m,
                Ibu = 30,
                Description = "An amber lager and the flagship product of Boston Brewing Company."
            };

            var beersRepository = new Mock<IBeersRepository>();
            beersRepository
                .Setup(x => x.GetBeerByIdAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(expectedBeer))
                .Verifiable();

            // Act
            var result = await _beersRepository.GetBeerByIdAsync(beerId);

            // Arrenge
            Assert.Equal(expectedBeer.Name, result.Name);

        }

        [Fact]
        public async Task GivenThereAreBeers_WhenRequestingAll_ThenShouldReturnAList()
        {
            // Arrenge
            var expectedBeers = new List<Beer>
            {
                new() { Id = 1, Name = "Boston Lager", Pack = "6, 12, 28", AbvPercentage = 5.0m, Ibu = 30, Description = "An amber lager and the flagship product of Boston Brewing Company."},
                new() { Id = 2, Name = "Cold Snap", Pack = "6, 12", AbvPercentage = 5.3m, Ibu = 15, Description = "n unfiltered white ale brewed with orange peel and spices, reformulated in 2023 to be \"smoother and more refreshing.\" "},
                new() { Id = 3, Name = "Summer Ale", Pack = "6, 12, 24", AbvPercentage = 5.3m, Ibu = 8, Description = "A wheat ale brewed with grains of paradise."},
                new() { Id = 4, Name = "OctoberFest", Pack = "6, 12, 24", AbvPercentage = 5.3m, Ibu = 16, Description = "A Marzen brewed for the start of fall."},
                new() { Id = 5, Name = "Cold IPA", Pack = "Winter variety pack", AbvPercentage = 6.0m, Ibu = 40, Description = "An India pale ale with notes of pine."}
            };

            var beersRepository = new Mock<IBeersRepository>();
            beersRepository
                .Setup(x => x.GetAllBeers())
                .ReturnsAsync(expectedBeers)
                .Verifiable();

            // Act
            var result = await _beersRepository.GetAllBeers();

            // Arrenge
            Assert.Equal(expectedBeers.Count, result.Count());
        }
    }
}
