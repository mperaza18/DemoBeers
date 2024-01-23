using DemoBeers.Application.Services;
using DemoBeers.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DemoBeers.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BeersController : ControllerBase
    {
        private readonly IBeerService _beerService;
        public BeersController(IBeerService beerService)
        {
            _beerService = beerService;
        }

        [HttpGet(Name = "GetById")]
        public async Task<Beer> GetById(int id)
        {
            return await _beerService.GetBeerByIdAsync(id);
        }

        [HttpGet(Name = "GetAll")]
        public async Task<IEnumerable<Beer>> GetAll()
        {
            return await _beerService.GetAllBeers();
        }
    }
}
