using Grocery.Core.Models;
using Grocery.App.ViewModels;
using Microsoft.Maui.Controls;

namespace Grocery.App.Views
{
    public partial class CategoriesView : ContentPage
    {
        public CategoriesView(CategoriesViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        // Event handler die XAML verwacht
        private async void OnCategorySelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Category selected)
            {
                // Navigeer naar ProductCategoriesView en geef CategoryId door
                await Shell.Current.GoToAsync($"productcategories?categoryId={selected.Id}");
            }
        }
    }
}