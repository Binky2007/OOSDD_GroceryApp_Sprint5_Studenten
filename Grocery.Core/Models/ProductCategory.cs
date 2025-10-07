namespace Grocery.Core.Models;

public class ProductCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public ProductCategory(int id, string name, int categoryId)
    {
        Id = id;
        Name = name;
        this.CategoryId = categoryId;
    }
    
}