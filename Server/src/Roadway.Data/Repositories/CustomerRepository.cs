using Microsoft.EntityFrameworkCore;
using Roadway.Domain.Aggregates.Customers;

namespace Roadway.Data.Repositories
{
    public class CustomerRepository : EfRepository<Customer>, ICustomerRepository
    {
        protected CustomerRepository(DbContext context) : base(context)
        {
        }
    }
}