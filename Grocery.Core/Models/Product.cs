using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class Product : Model
    {
        [ObservableProperty]
        private int stock;

        [ObservableProperty]
        private decimal price; // 👈 nieuwe property

        public DateOnly ShelfLife { get; set; }

        public Product(int id, string name, int stock)
            : this(id, name, stock, 0m, default) { }

        public Product(int id, string name, int stock, decimal price)
            : this(id, name, stock, price, default) { }

        public Product(int id, string name, int stock, decimal price, DateOnly shelfLife)
            : base(id, name)
        {
            Stock = stock;
            Price = price;
            ShelfLife = shelfLife;
        }

        public override string? ToString()
        {
            return $"{Name} - {Stock} op voorraad - €{Price:F2}";
        }
    }
}