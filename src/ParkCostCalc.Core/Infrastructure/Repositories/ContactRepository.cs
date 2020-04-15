using ParkCostCalc.Core.Models;

namespace ParkCostCalc.Core.Infrastructure.Repositories
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
