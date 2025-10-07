namespace Grocery.Core.Interfaces.Repositories
{
    using Grocery.Core.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;


    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);
    }
 
}

