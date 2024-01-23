using DemoBeers.Domain.Entities;

namespace DemoBeers.Persistance.Repositories
{
    public class BeersRepository : IBeersRepository
    {
        public async Task<IEnumerable<Beer>> GetAllBeers()
        {
            return await Task.FromResult(MockBeerData.Beers.ToList());
        }

        public async Task<Beer> GetBeerByIdAsync(int id)
        {
            var beer = MockBeerData.Beers.FirstOrDefault(x => x.Id == id);
            return (beer != null)
                ? await Task.FromResult(beer) 
                : await Task.FromResult(new Beer() { Name = string.Empty, Pack = string.Empty});
        }
    }

    public class MockBeerData
    {
        public static IEnumerable<Beer> Beers
        { 
            get 
            {  
                return new List<Beer>()
                {
                    new() { Id = 1, Name = "Boston Lager", Pack = "6, 12, 28", AbvPercentage = 5.0m, Ibu = 30, Description = "An amber lager and the flagship product of Boston Brewing Company."},
                    new() { Id = 2, Name = "Cold Snap", Pack = "6, 12", AbvPercentage = 5.3m, Ibu = 15, Description = "n unfiltered white ale brewed with orange peel and spices, reformulated in 2023 to be \"smoother and more refreshing.\" "},
                    new() { Id = 3, Name = "Summer Ale", Pack = "6, 12, 24", AbvPercentage = 5.3m, Ibu = 8, Description = "A wheat ale brewed with grains of paradise."},
                    new() { Id = 4, Name = "OctoberFest", Pack = "6, 12, 24", AbvPercentage = 5.3m, Ibu = 16, Description = "A Marzen brewed for the start of fall."},
                    new() { Id = 5, Name = "Cold IPA", Pack = "Winter variety pack", AbvPercentage = 6.0m, Ibu = 40, Description = "An India pale ale with notes of pine."}
                };
            }
        }

    }
}
