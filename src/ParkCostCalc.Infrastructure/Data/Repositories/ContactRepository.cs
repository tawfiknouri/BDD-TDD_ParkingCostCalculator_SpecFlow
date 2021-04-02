
using ParkCostCalc.Core.Interfaces;
using ParkCostCalc.Core.Models;

namespace ParkCostCalc.Infrastructure.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private ParkingDbContext _dbContext;

        public ContactRepository(ParkingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Contact CreateContact(Contact contact)
        {
            _dbContext.Add(contact);
            _dbContext.SaveChangesAsync();
            return contact;
        }
    }
}
