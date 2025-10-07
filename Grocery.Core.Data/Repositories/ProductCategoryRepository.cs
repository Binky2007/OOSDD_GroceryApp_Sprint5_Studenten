namespace Grocery.Core.Repositories; // <- niet Models

using Grocery.Core.Models;
using Grocery.Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ProductCategoryRepository : IProductCategoryRepository
{
    private readonly List<ProductCategory> _productCategories = new();

    public Task AddAsync(ProductCategory productCategory)
    {
        productCategory.Id = _productCategories.Count + 1;
        _productCategories.Add(productCategory);
        return Task.CompletedTask;
    }

    public Task<List<ProductCategory>> GetByCategoryIdAsync(int categoryId)
    {
        var result = _productCategories.Where(pc => pc.CategoryId == categoryId).ToList();
        return Task.FromResult(result);
    }
}