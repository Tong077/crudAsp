using Microsoft.EntityFrameworkCore;
using Crud.Data;
using Crud.Models;
namespace Crud.Repository
{
    public interface ICategoryService
    {
        Task<bool> Create(Category category);
        Task<bool> Update(Category category);
        Task<bool> Delete(Category category);

        Task<Category> Get(int CategoryId);
        Task <List<Category>> GetAll();

    }
}
