namespace Grocery.Core.Data.Repositories;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CategoryRepository : ICategoryRepository
{
    private readonly List<Category> _categories = new();

    public Task AddAsync(Category category)
    {
        category.Id = _categories.Count + 1;
        _categories.Add(category);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    {
        _categories.RemoveAll(c => c.Id == id);
        return Task.CompletedTask;
    }

    public Task<List<Category>> GetAllAsync() => Task.FromResult(_categories);

    public Task<Category> GetByIdAsync(int id) => 
        Task.FromResult(_categories.FirstOrDefault(c => c.Id == id));

    public Task UpdateAsync(Category category)
    {
        var index = _categories.FindIndex(c => c.Id == category.Id);
        if (index >= 0) _categories[index] = category;
        return Task.CompletedTask;
    }
}
