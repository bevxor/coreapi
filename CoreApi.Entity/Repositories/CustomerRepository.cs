using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreApi.Entity.Contracts;
using CoreApi.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace CoreApi.Entity.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DatabaseContext _databaseContext;

        public CustomerRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _databaseContext.Customer.AsNoTracking()
                .ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int customerId)
        {
            throw new NullReferenceException("Testing raygun error");
            return await _databaseContext.Customer.AsNoTracking()
                .SingleOrDefaultAsync(x => x.CustomerId.Equals(customerId));
        }

        public async Task<bool> DeleteAsync(int customerId)
        {
            var entity =
                await _databaseContext.Customer
                    .SingleOrDefaultAsync(x => x.CustomerId.Equals(customerId));

            if (entity == null) return false;


            _databaseContext.Customer.Remove(entity);
            await _databaseContext.SaveChangesAsync();

            return true;
        }

        public async Task CreateAsync(Customer customer)
        {
            await _databaseContext.Customer.AddAsync(customer);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
            _databaseContext.Entry(customer).CurrentValues.SetValues(customer);
            await _databaseContext.SaveChangesAsync();
        }
    }
}