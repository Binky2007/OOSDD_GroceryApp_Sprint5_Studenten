namespace Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IProductCategoryService
{
    Task<List<ProductCategory>> GetByCategoryIdAsync(int categoryId);
    Task AddProductCategoryAsync(ProductCategory productCategory);
}
