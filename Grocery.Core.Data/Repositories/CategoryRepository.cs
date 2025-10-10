using Grocery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grocery.Core.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public async Task<List<Category>> GetAllAsync()
        {
            
            return new List<Category>
            {
                new Category { Id = 1, Name = "Zuivel" },
                new Category { Id = 2, Name = "Bakkerij" },
                new Category { Id = 3, Name = "Ontbijtgranen" },
                new Category { Id = 4, Name = "Groenten" },
            };

        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return (await GetAllAsync()).FirstOrDefault(c => c.Id == id);
        }
    }

}