using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using WebAPIDotNETCore.Entities;
using WebAPIDotNETCore.POCO;

namespace WebAPIDotNETCore.Context
{
    public class LocationDBContext : DbContext
    {
        public DbSet<LocationEntity> Locations { get; set; }
        public LocationDBContext(DbContextOptions<LocationDBContext> options) : base(options)
        {
        }
    }
}
