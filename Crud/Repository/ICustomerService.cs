using Microsoft.EntityFrameworkCore;
using Crud.Data;
using Crud.Models;


namespace Crud.Repository
{
    public interface ICustomerService
    {
        Task<bool> Create(customers customer);
        Task<bool> Update(customers customer);
        Task<bool> Delete(customers customer);
        Task<customers> GetById(int CustomerId);
        Task<List<customers>> GetAll();

    }
}
