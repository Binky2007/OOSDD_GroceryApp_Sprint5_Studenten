namespace Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


public interface ICategoryService
{
    Task<List<Category>> GetCategoriesAsync();
    Task AddCategoryAsync(Category category);
}
