using CommunityToolkit.Mvvm.ComponentModel;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;



namespace Grocery.App.ViewModels
{
    public class ProductCategoriesViewModel
    {
        private readonly IProductService _service;

        public ObservableCollection<Product> Products { get; } = new();

        public ProductCategoriesViewModel(IProductService service)
        {
            _service = service;
        }

        public async Task Load(int categoryId)
        {
            var list = _service.GetByCategoryId(categoryId);
            Products.Clear();
            foreach (var product in list)
                Products.Add(product);
        }
    }



}