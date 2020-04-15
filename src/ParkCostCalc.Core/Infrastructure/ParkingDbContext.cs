using Microsoft.EntityFrameworkCore;
using ParkCostCalc.Core.Models;
namespace ParkCostCalc.Core.Infrastructure
{
    public class ParkingDbContext : DbContext
    {

        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
