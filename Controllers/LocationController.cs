using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDotNETCore.Entities;
using WebAPIDotNETCore.POCO;
using WebAPIDotNETCore.Repository;

namespace WebAPIDotNETCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationRepository _locationRepository;
        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        [HttpPost("save-location")]
        public async Task<bool> AddLocation([FromBody] LocationEntity location)
        {
            return await _locationRepository.SaveLocation(location);
        }

        [HttpPost("search-location")]
        public async Task<IEnumerable<LocationEntity>> GetLocations([FromBody] LocationSearch search)
        {
            return await _locationRepository.SearchLocation(search.FromTime, search.ToTime);
        }
    }
}
