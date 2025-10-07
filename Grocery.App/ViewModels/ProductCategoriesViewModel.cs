using CommunityToolkit.Mvvm.ComponentModel;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;


namespace Grocery.App.ViewModels
{
    [QueryProperty(nameof(CategoryId), "categoryId")]
    public partial class ProductCategoriesViewModel : ObservableObject
    {
        private readonly IProductCategoryService _service;

        public ObservableCollection<ProductCategory> ProductCategories { get; } = new();

        [ObservableProperty]
        private int _categoryId;

        public ProductCategoriesViewModel(IProductCategoryService service)
        {
            _service = service;
        }

        partial void OnCategoryIdChanged(int value)
        {
            LoadProductCategories();
        }

        private async void LoadProductCategories()
        {
            var list = await _service.GetByCategoryIdAsync(CategoryId);
            ProductCategories.Clear();
            foreach (var pc in list)
                ProductCategories.Add(pc);
        }
    }
}