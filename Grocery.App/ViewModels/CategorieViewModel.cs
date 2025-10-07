using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    public partial class CategoriesViewModel : ObservableObject
    {
        private readonly ICategoryService _categoryService;

        public ObservableCollection<Category> Categories { get; } = new();

        public CategoriesViewModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            LoadCategories();
        }

        [RelayCommand]
        private async void LoadCategories()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            Categories.Clear();
            foreach (var c in categories)
                Categories.Add(c);
        }
    }
}