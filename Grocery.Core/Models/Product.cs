using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class Product : Model
    {
        [ObservableProperty]
        private int stock;
        
        [ObservableProperty]
        private int categoryId;


        [ObservableProperty]
        private decimal price; 

        public DateOnly ShelfLife { get; set; }

        public Product(int id, string name, int stock)
            : this(id, name, stock, 0m, default,0) { }

     

        public Product(int id, string name, int stock, decimal price, DateOnly shelfLife,int categoryId)
            : base(id, name)
        {
            Stock = stock;
            Price = price;
            ShelfLife = shelfLife;
            CategoryId = categoryId;
        }

        public override string? ToString()
        {
            return $"{Name} - {Stock} op voorraad - €{Price:F2}";
        }
    }
}