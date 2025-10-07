namespace Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IProductCategoryRepository
{
    Task<List<ProductCategory>> GetByCategoryIdAsync(int categoryId);
    Task AddAsync(ProductCategory productCategory);
}
