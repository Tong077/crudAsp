using Microsoft.EntityFrameworkCore;
using Crud.Data;
using Crud.Models;
using System.Drawing.Text;

namespace Crud.Repository
{
    public class CategoryServiceImpl : ICategoryService
    {
        private readonly EntityDbContext context;


        public CategoryServiceImpl(EntityDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> Create(Category category)
        {
            context.Categories.Add(category);
            return await context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Update(Category category)
        {
            context.Categories.Update(category);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(Category category)
        {

        
            context.Categories.Remove(category);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<List<Category>> GetAll()
        {
            var results = context.Categories;
            return await results.ToListAsync();
        }

        public Task<Category> Get(int CategoryID)
        {
            var category = context.Categories.FirstOrDefaultAsync(x => x.CategoryID == CategoryID);
            return category;
        }

       
    }

    

    
}
