using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    public class CategoriesViewModel
    {
        private readonly ICategoryService _service;
        public ObservableCollection<Category> Categories { get; } = new();

        public CategoriesViewModel(ICategoryService service)
        {
            _service = service;
            LoadCategories();
        }

        private async void LoadCategories()
        {
            var list = await _service.GetCategoriesAsync();
            foreach (var cat in list)
                Categories.Add(cat);
        }
    }

}