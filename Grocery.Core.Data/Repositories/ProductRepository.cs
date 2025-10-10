using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;
        public ProductRepository()
        {
            products = [
                new Product(1, "Melk", 300,1.49m, new DateOnly(2025, 9, 25),1),
                new Product(2, "Kaas", 100,4.75m, new DateOnly(2025, 9, 30),1),
                new Product(3, "Brood", 400,2.10m, new DateOnly(2025, 9, 12),2),
                new Product(4, "Cornflakes", 0,3.25m, new DateOnly(2025, 12, 31),3)
            ];
        }
        public List<Product> GetAll()
        {
            return products;
        }
        public List<Product> GetByCategoryId(int categoryId)
        {
            return products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            Product? product = products.FirstOrDefault(p => p.Id == item.Id);
            if (product == null) return null;
            product.Id = item.Id;
            return product;
        }
    }
}
