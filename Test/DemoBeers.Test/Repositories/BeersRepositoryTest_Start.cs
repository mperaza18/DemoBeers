using DemoBeers.Persistance.Repositories;

namespace DemoBeers.Test.Repositories
{
    public class BeersRepositoryTest_Start
    {
        private readonly BeersRepository _beersRepository;

        public BeersRepositoryTest_Start()
        {
            _beersRepository = new BeersRepository();
        }

        [Fact]
        public async Task GivenThereAreBeers_WhenPassingId_ThenShouldReturnASingleBeer()
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
