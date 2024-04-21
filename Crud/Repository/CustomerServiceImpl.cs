using Microsoft.EntityFrameworkCore;
using Crud;
using Crud.Models;
using Crud.Data;

namespace Crud.Repository
{
    public class CustomerServiceImpl : ICustomerService
    {
        private readonly EntityDbContext context;

        public CustomerServiceImpl(EntityDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> Create(customers customer)
        {
           context.Customers.Add(customer);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(customers customer)
        {
            context.Customers.Remove(customer);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<List<customers>> GetAll()
        {
            var results = context.Customers;
            return await results.ToListAsync();
        }

        public Task<customers> GetById(int CustomerId)
        {
            var customer = context.Customers.FirstOrDefaultAsync(x => x.CustomerId == CustomerId);
            return customer;
        }

        public async Task<bool> Update(customers customer)
        {
            context.Customers.Update(customer);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
