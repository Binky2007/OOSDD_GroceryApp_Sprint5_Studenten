namespace Grocery.Core.Services;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.Generic;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _repository;

    public CategoryService(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public Task AddCategoryAsync(Category category) => _repository.AddAsync(category);

    public Task<List<Category>> GetCategoriesAsync() => _repository.GetAllAsync();
}
