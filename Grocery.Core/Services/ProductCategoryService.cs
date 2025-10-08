namespace Grocery.Core.Services;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.Generic;

public class ProductCategoryService : IProductCategoryService
{
    private readonly IProductCategoryRepository _repository;

    public ProductCategoryService(IProductCategoryRepository repository)
    {
        _repository = repository;
    }

    public Task AddProductCategoryAsync(ProductCategory productCategory) => _repository.AddAsync(productCategory);

    public Task<List<ProductCategory>> GetByCategoryIdAsync(int categoryId) => _repository.GetByCategoryIdAsync(categoryId);
}
