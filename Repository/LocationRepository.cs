using Microsoft.EntityFrameworkCore;
using WebAPIDotNETCore.Context;
using WebAPIDotNETCore.Entities;
using WebAPIDotNETCore.POCO;

namespace WebAPIDotNETCore.Repository
{
    public interface ILocationRepository
    {
        Task<IEnumerable<LocationEntity>> SearchLocation(TimeOnly fromTime, TimeOnly toTime);
        Task<bool> SaveLocation(LocationEntity location);
    }
    public class LocationRepository : ILocationRepository
    {
        private readonly LocationDBContext  _context;
        public LocationRepository(LocationDBContext context) { 
            _context = context;
        }

        public async Task<IEnumerable<LocationEntity>> SearchLocation(TimeOnly fromTime, TimeOnly toTime)
        {
            return await _context.Locations.Where(x => x.OpeningTime <= fromTime && x.EndingTime >= toTime).ToListAsync();
        }

        public async Task<bool> SaveLocation(LocationEntity location)
        {
            _context.Locations.Add(location);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
